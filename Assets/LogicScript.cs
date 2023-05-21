using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text ScoreText;

    [ContextMenu("Increase Score")]
    public void adder()
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
