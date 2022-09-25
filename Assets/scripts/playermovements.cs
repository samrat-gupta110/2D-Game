using UnityEngine;

public class playermovements : MonoBehaviour
{

    public float speed = 10f;
    public float movement = 0f;
    public Rigidbody2D rb;
    public float jumpspeed = 10f;
    public bool playeronground;
    public Animator playeranimation;
    public Vector3 respawnpoint;
    public Levelmanagers gamelevelmanager;
    public int maxhealth = 100;
    public int currenthealth;
    public float x;
    public float y;
    public float dashforce;
    public float startdashtimer;
    float currentdashtimer;
    public float dashdirectionn;
    public float dashdirection2;
    public bool isdashing;

    public HealthBar healthBar;
   


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playeranimation = GetComponent<Animator>();
        respawnpoint = transform.position;
        gamelevelmanager = FindObjectOfType<Levelmanagers>();
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {

        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            rb.velocity = new Vector2(movement * speed * Time.deltaTime, rb.velocity.y);
            transform.localScale = new Vector2(-0.8504527f, 0.8504527f);
        }

        else if(movement < 0f)
        {
            rb.velocity = new Vector2(movement * speed * Time.deltaTime, rb.velocity.y);
            transform.localScale = new Vector2(0.8504527f, 0.8504527f);
            
        }

        else
        {
             rb.velocity = new Vector2(movement * speed * Time.deltaTime, rb.velocity.y);
        }

        if(Input.GetButtonDown("Jump")&& playeronground)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
            playeronground = false;
        }
        
        if(Input.GetKeyDown(KeyCode.Q) && playeronground && movement != 0)
        {
            isdashing = true;
            currentdashtimer = startdashtimer;
            rb.velocity = Vector2.zero;
        }

        if(isdashing)
        {
            rb.velocity = new Vector2(movement * dashforce, rb.velocity.y);
            currentdashtimer = currentdashtimer - Time.deltaTime;

            if(currentdashtimer <= 0)
            {
                isdashing = false;
            }
        }
        playeranimation.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        playeranimation.SetBool("onground", playeronground);
        playeranimation.SetBool("playerdash", isdashing);




    }

    public void TakeDamage(int damage)
    {
        currenthealth = currenthealth - damage;
        healthBar.SetHealth(currenthealth);
    }

    

    
     
     void OnTriggerEnter2D(Collider2D point)
    {
        if(point.tag == "FallDectctors")
        {
            gamelevelmanager.Respawn();
        }

        if(point.tag == "Checkpoints")
        {
            respawnpoint = point.transform.position;
        }
    }


}
