using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag == "ground")
        {
            FindObjectOfType<playermovements>().playeronground = true;

        }

        if(collisionInfo.collider.tag == "boxes")
        {
            FindObjectOfType<playermovements>().playeronground = true;
        }

        if(collisionInfo.collider.tag == "movingposition")
        {
            FindObjectOfType<playermovements>().playeronground = true;
        }

        if(collisionInfo.collider.tag == "movingposition")
        {
            FindObjectOfType<playermovements>().transform.parent = collisionInfo.transform;
            FindObjectOfType<playermovements>().playeronground = true;
        }

        if(collisionInfo.collider.tag == "enemies")
        {
            FindObjectOfType<playermovements>().TakeDamage(20);
            FindObjectOfType<playermovements>().playeranimation.SetTrigger("damage");
        }
        
    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag == "movingposition")
        {
            FindObjectOfType<playermovements>().transform.parent = null;
            FindObjectOfType<playermovements>().playeronground = false;
        }
    }
}
