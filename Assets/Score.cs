using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int playerScore = 0;
    int aiScore = 0;
    TMP_Text scoreField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScore = 0;
        aiScore = 0;
        scoreField = GetComponent<TMP_Text>();
        ScoreUpdate(playerScore, aiScore);
    }

    // Update is called once per frame
    void ScoreUpdate(int score1, int score2)
    {
        scoreField.text = (score1 + " : " + score2);
    }
}
