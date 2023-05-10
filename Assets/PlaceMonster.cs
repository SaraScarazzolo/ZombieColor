using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class place_m : MonoBehaviour
{



public GameObject monsterPrefab;
private GameObject monster;



//private GameManagerBehavior gameManager;


    // Start is called before the first frame update
    /*void Start()
    {
      gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();


    }*/


    // Update is called once per frame
    void Update()
    {
     
    }
   
   
    //1
//1
void OnMouseUp()
{
  //2
  if (CanPlaceMonster())
  {
    //3
    monster = (GameObject) 
      Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    //4
    AudioSource audioSource = gameObject.GetComponent<AudioSource>();
    audioSource.PlayOneShot(audioSource.clip);

    // TODO: Deduct gold
  }
}



private bool CanPlaceMonster()
{
  return monster == null;
}


}

