using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public float forceRate = 1f;

    private Rigidbody2D rb2D;
    private float force = 0f;
    private float randforce;
    private float maxforce = 500f;
    private float torqueRate = 2f;


    private bool flipped = false;
    private bool fell = false;

    public float height = 0f;

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
            //just making sure that height is zero when we aren't in the air
            rb2D.rotation = 0;
            height = 0;
            force += forceRate;
         }
         else if(!flipped && Input.GetMouseButtonUp(0))
         {
            //We reward the player for flipping the pancake.
            //Also, ensures that there is at least 100 points added to the score.
            height += 1.0f;
            if(force > maxforce)
            {
                force = maxforce;
            }
            rb2D.AddForce(transform.up * force);
            rb2D.AddForce(transform.right * randforce);
            rb2D.AddTorque(randforce * torqueRate);
            flipped = true;
         }

         //adds on to height, with Time.deltaTime used so that height is not dependent on framerate.
         else if (flipped)
        {
            height += (1.0f * Time.deltaTime);
        }

         //gives no points for having fallen
         else if (fell)
        {
            height = 0;
        }

         //Adjusted this to make it easier to adjust to losing the pancake
         if (rb2D.position.y < -10)
        {
            GameManager.Instance.resetScore();
            rb2D.position = new Vector3(0f, 1f, 0f);
            rb2D.velocity = new Vector2(0f, 0f);
            fell = true;
        }

    }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        flipped = false;
        fell = false;
    }

}
