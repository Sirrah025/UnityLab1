using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int baseScore; //multiplied by height on a succesful flip
    public TextMeshProUGUI scoreText;

    private int score; //total score that is displayed

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    //called when pancake succesfully flips
    //increases score by height times baseScore
    internal void addScore(int height)
    {
        score += baseScore * height;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
