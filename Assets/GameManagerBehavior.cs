using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{

    public Text goldLabel;
    private int gold;
    // Start is called before the first frame update
    void Start()
    {
        Gold = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Gold {
        get
        { 
            return gold;
        }
        set
        {
            gold = value;
            goldLabel.GetComponent<Text>().text = "GOLD: " + gold;
        }
    }
}
