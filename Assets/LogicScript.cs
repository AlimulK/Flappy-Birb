using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text ScoreText;

    [ContextMenu("Increase Score")]
    public void Adder()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Menu");
    }
}
