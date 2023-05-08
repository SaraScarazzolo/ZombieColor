using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMonster : MonoBehaviour{

  private GameManagerBehavior gameManager;
  public GameObject monsterPrefab;
  private GameObject monster;

  // Start is called before the first frame update
  void Start(){
    gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
  }

  // Update is called once per frame
  void Update(){
      
  }

  private bool CanUpgradeMonster(){
    if (monster != null)
    {
      MonsterData monsterData = monster.GetComponent<MonsterData>();
      MonsterLevel nextLevel = monsterData.GetNextLevel();

      if (nextLevel != null){
        return gameManager.Gold >= nextLevel.cost;
      }
    }

    return false;
  }

  void OnMouseUp(){
    if (CanPlaceMonster()){
    monster = (GameObject) 
    Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    AudioSource audioSource = gameObject.GetComponent<AudioSource>();
    audioSource.PlayOneShot(audioSource.clip);
    gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
    }

    else if (CanUpgradeMonster()){
      monster.GetComponent<MonsterData>().IncreaseLevel();
      AudioSource audioSource = gameObject.GetComponent<AudioSource>();
      audioSource.PlayOneShot(audioSource.clip);
      gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
    }
  }

  private bool CanPlaceMonster(){
    int cost = monsterPrefab.GetComponent<MonsterData>().levels[0].cost;
    return monster == null && gameManager.Gold >= cost;
  }
}

