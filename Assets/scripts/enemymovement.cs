
using UnityEngine;

public class enemymovement : MonoBehaviour
{

    public float speed = 100f;
    public bool moveright;
    public float maxhealth;
    public float curremthealth;
    public Animator enemeyanimation;
    public Rigidbody2D rb;

    void Start()
    {
        curremthealth = maxhealth;
        enemeyanimation = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
       if(moveright)
        {
            
            transform.Translate(2 * Time.deltaTime*speed*Time.deltaTime, 0, 0);
            transform.localScale = new Vector2(0.3537557f, 0.3537557f);
        }

        else
        {

            transform.Translate(-2* Time.deltaTime*speed*Time.deltaTime, 0, 0);
            transform.localScale = new Vector2(-0.3537557f, 0.3537557f);
        }

        enemeyanimation.SetFloat("enemyspeed" , speed);

    }



    public void  enemeydamange(int damange)
    {
        curremthealth = curremthealth - damange;
        enemeyanimation.SetTrigger("damage");

        if (curremthealth <= 0)
        {
            die();
        }

    }

    void die()
    {
        Debug.Log("we die");
        enemeyanimation.SetBool("dead", true);
        
       
    }

     void OnCollisionEnter2D(Collision2D enemeycollision)
    {
        if(enemeycollision.collider.tag == "Player")
        {
            enemeydamange(20);
            enemeyanimation.SetTrigger("damage");
        }
    }
    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("turn"))
        {
            if(moveright)
            {
                moveright = false;
            }
            else
            {
                moveright = true;
            }

        }
        
    }
}
