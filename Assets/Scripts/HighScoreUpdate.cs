using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScoreUpdate : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void Update()
    {
        text.text = "High Score: " + Player.highScore.ToString();
    }
}
