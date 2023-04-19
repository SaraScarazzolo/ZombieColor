using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMonster : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject monsterPrefab;
    private GameObject monster;
        
        private bool CanPlaceMonster()
        {
        return monster == null;
        }

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
}
