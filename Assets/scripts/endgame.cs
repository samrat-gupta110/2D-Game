using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endgame : MonoBehaviour
{

    public Sprite redflag2;
    public Sprite blueflag;
    private SpriteRenderer gameending;
    public bool endpointreached;
    public GameObject levelcompleteUI;
    // Start is called before the first frame update
    void Start()
    {
        gameending = GetComponent<SpriteRenderer>();
    }

    public void levelcomplete()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            gameending.sprite = blueflag;
            endpointreached = true;
            levelcompleteUI.SetActive(true);
        }
    }
}
