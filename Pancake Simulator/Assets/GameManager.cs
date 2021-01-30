using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int baseScore; //multiplied by height on a succesful flip

    private int score; //total score that is displayed
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //called when pancake succesfully flips
    //increases score by height times baseScore
    void addScore<T>(int height)
    {
        score += baseScore * height;
    }
}
