using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercombat : MonoBehaviour
{
    public Animator combatanimation;
    public Transform attackpoint;
    public float attackrange = 0.5f;
    public LayerMask enemylayers;
    public int attackdamage = 20;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    void Attack()
    {
        combatanimation.SetTrigger("playercombat");

        Collider2D[] hitenemies =  Physics2D.OverlapCircleAll(attackpoint.position , attackrange , enemylayers);

        foreach (Collider2D enemy in hitenemies)
        {
            enemy.GetComponent<enemymovement>().enemeydamange(attackdamage);
           
        }

    }

     void OnDrawGizmosSelected()
    {

        if(attackpoint == null)
        
            return;
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
        
      
    }
}
