using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public int Points { get; private set; }

    public void AddPoints(int points)
    {
        Points += points;
    }

    internal void DecrementScore()
    {
        throw new NotImplementedException();
    }

    internal void IncrementScore()
    {
        throw new NotImplementedException();
    }

    internal void SetScore(int v)
    {
        throw new NotImplementedException();
    }
}