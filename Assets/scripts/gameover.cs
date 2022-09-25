using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public float x;
    public float y;
    public float restartdelay = 1f;
    public GameObject oversceneUI;
    

    void Update()
    {
        if (FindObjectOfType<playermovements>().currenthealth <= 0)
        {
            oversceneUI.SetActive(true);
            FindObjectOfType<playermovements>().playeranimation.SetBool("playerdead", true);
            Invoke("restart", restartdelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
