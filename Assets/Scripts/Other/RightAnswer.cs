using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RightAnswer : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void rightAnswer()
    {
        score = score + 1;
    }
}
