using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreUpdate : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Player player;
    public void Update()
    {
        text.text = "Score: " + player.score.ToString();
    }
}
