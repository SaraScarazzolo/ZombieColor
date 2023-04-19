using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MonsterLevel
{
  public int cost;
  public GameObject visualization;
}

public class MonsterData : MonoBehaviour
{
	public List<MonsterLevel> levels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
