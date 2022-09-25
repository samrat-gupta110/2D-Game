using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class timeball : MonoBehaviour
{

    public float t;
    public Vector3 Startposition;
    public Vector3 endposition;
    public float timetoreach;
    public float speed;







    // Start is called before the first frame update
    void Start()
    {
        Startposition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        t = t + Time.deltaTime;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(Startposition, endposition, step);
        
    } 
    
 
   
    

    public IEnumerator movetoposition(Transform transform, Vector3 endposition, float timetomove)
    {
         
        Startposition = transform.position;
        t = 0f;
        while (t < 1)
        {
            t = t + Time.deltaTime / timetomove;
            float step = speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(Startposition, endposition, step);
            yield return null;
        }


    }
}

