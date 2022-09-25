using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingcollision : MonoBehaviour
{
    public float forwardforce;
    public Rigidbody2D rb;
    public float speed;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "movingposition")
        {
            Debug.Log("hello");
        }
           
    }
}
