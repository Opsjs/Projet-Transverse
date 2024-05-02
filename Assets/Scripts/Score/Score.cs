using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score 
{
    public int hiddenObjectFound;
    public string username;

    public Score(int hiddenObjectFound, string username)
    {
        this.hiddenObjectFound = hiddenObjectFound;
        this.username = username;
    }
}
