﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data_Bridge {

    private static Vector2 playerPosition;
    private static float score;

    //Function for setting and getting values
    public static Vector2 PlayerPosition
    {
        get
        {
            return playerPosition;
        }
        set
        {
            playerPosition = value;
        }
    }

    //Function for setting and getting value
    public static float Score { get; set; }

    public static float TimesPlayed { get; set; }
}