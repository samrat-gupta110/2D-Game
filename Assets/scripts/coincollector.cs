using UnityEngine;

public class coincollector : MonoBehaviour
{
    public float sorce;
    private Levelmanagers coinslevelmanager;
    public int coinvalues;

     void Start()
    {
        coinslevelmanager = FindObjectOfType<Levelmanagers>();   
    }

    void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag == "Player")
        {
            coinslevelmanager.AddCoins(coinvalues);
            Destroy(gameObject);
        }
    }

}
