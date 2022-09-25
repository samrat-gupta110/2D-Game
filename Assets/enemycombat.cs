using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycombat : MonoBehaviour
{

    public Animator Animator;
    void attack()
    {
        Animator.SetTrigger("attack");
    }
}
