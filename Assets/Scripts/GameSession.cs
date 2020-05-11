using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    private static GameSession _instance;
    public static GameSession Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("GameSession is null");
            return _instance;
        }
    }

    int score = 0;

    private void Awake()
    {
        _instance = this;
    }

    public int GetScore()
    {
        return score;
    }


    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }



}
