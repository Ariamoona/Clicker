using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Game
{
    private Score score;

    public Game(Score score)
    {
        this.score = score;
    }

    public void StartGame()
    {
        score.SetScore(5); 
    }

    public void EndGame()
    {
        score.SetScore(0); 
    }
}
