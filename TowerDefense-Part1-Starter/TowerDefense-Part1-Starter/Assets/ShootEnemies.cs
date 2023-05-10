using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;


public class ShootEnemies : MonoBehaviour
{

    public List<GameObject> enemiesInRange;

    // Start is called before the first frame update
    void Start()
    {
        enemiesInRange = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 1
void OnEnemyDestroy(GameObject enemy)
{
  enemiesInRange.Remove (enemy);
}

void OnTriggerEnter2D (Collider2D other)
{
// 2
  if (other.gameObject.tag.Equals("Enemy"))
  {
    enemiesInRange.Add(other.gameObject);
    EnemyDestructionDelegate del =
        other.gameObject.GetComponent<EnemyDestructionDelegate>();
    del.enemyDelegate += OnEnemyDestroy;
  }
}
// 3
void OnTriggerExit2D (Collider2D other)
{
  if (other.gameObject.tag.Equals("Enemy"))
  {
    enemiesInRange.Remove(other.gameObject);
    EnemyDestructionDelegate del =
        other.gameObject.GetComponent<EnemyDestructionDelegate>();
    del.enemyDelegate -= OnEnemyDestroy;
  }
}

}
