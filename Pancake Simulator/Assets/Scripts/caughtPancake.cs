using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caughtPancake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //gets height from collided pancake and passes to addScore
        float h = collision.gameObject.GetComponent<flip>().height;
        GameManager.Instance.addScore(h);
    }
}
