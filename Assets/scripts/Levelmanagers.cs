using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Levelmanagers : MonoBehaviour
{
    public float respawndelay;
    public playermovements gameplayer;
    public int coins;
    public Text cointext;
    // Start is called before the first frame update
    void Start()
    {
        gameplayer = FindObjectOfType<playermovements>();
        cointext.text = "Score: " + coins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        StartCoroutine("RespawnTime");
    }

    public IEnumerator RespawnTime()
    {
        gameplayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawndelay);
        gameplayer.transform.position = gameplayer.respawnpoint;
        gameplayer.gameObject.SetActive(true);
    }

    public void AddCoins(int numberofcoins)
    {
        coins += numberofcoins;
        cointext.text = "Score: " + coins;
    }
}
