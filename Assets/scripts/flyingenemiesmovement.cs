using UnityEngine;

public class flyingenemiesmovement : MonoBehaviour
{
    public float speed = 100f;
    public bool moveright;


    // Update is called once per frame
    void Update()
    {
        if (moveright)
        {

            transform.Translate(2 * Time.deltaTime * speed * Time.deltaTime, 0, 0);
            transform.localScale = new Vector2(1f, 1f);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed * Time.deltaTime, 0, 0);
            transform.localScale = new Vector2(-1f, 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("turn2"))
        {
            if (moveright)
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
