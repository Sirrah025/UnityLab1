using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public float forceRate = 1;

    private Rigidbody2D rb2D;
    private float force = 0f;
    private float randforce;
    private bool flipped = false;
    private float maxforce = 500f;
    private float torqueRate = 2f;
    public int height;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        randforce = Random.Range(-250f, 250f);
    }

    // Update is called once per frame
    void Update()
    {
         randforce = Random.Range(-250f, 250f);
         if (!flipped && Input.GetMouseButton(0))
         {
             force += forceRate;
         }
         else if(!flipped && Input.GetMouseButtonUp(0))
         {
            if(force > maxforce)
            {
                force = maxforce;
            }
             rb2D.AddForce(transform.up * force);
             rb2D.AddForce(transform.right * randforce);
             rb2D.AddTorque(randforce * torqueRate);
             //flipped = true;
         } 

         if (rb2D.position.y < -5)
        {
            rb2D.position = Vector3.zero;
        }

    }

    public bool isFlipped()
    {
        return flipped;
    }
}
