using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointcontroller : MonoBehaviour
{

    public Sprite redflag;
    public Sprite greenflag;
    private SpriteRenderer checkpointspriterenderer;
    public bool checkpointreached;
    // Start is called before the first frame update
    void Start()
    {
        checkpointspriterenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if(collisionInfo.tag =="Player")
        {
            checkpointspriterenderer.sprite = greenflag;
            checkpointreached = true;
        }
    }
}
