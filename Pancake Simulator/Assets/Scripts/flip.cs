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
         if (!flipped && Input.GetMouseButton(0))
         {
             force += forceRate;
         }
         else if(!flipped && Input.GetMouseButtonDown(0))
         {
             rb2D.AddForce(transform.up * force);
             rb2D.AddForce(transform.right * randforce);
             flipped = true;
         } 
    }

    public bool isFlipped()
    {
        return flipped;
    }
}
