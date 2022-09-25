using UnityEngine;

public class playercamers : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public Vector3 playerposition;
    public float camerasmooting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerposition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        if(player.transform.position.x > 0f)
        {
            playerposition = new Vector3(playerposition.x + offset, playerposition.y, playerposition.z);
        }
        else
        {
            playerposition = new Vector3(playerposition.x - offset, playerposition.y, playerposition.z);
        }

        transform.position = playerposition;
        
    }
}
