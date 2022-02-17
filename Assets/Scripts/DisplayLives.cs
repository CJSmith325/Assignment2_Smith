using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayLives : MonoBehaviour
{
    PlayerLives playerLives;
    public Text text;
    
    private void Update()
    {
        text.text = "Lives: " + (playerLives.playerLives.ToString());
    }
}

