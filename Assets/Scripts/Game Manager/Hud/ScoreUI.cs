using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        
        Score.Instance.onScoreChanged.AddListener(UpdateScoreUI);
    }

    private void UpdateScoreUI(int newScore)
    {
        
        scoreText.text = "Score: " + newScore.ToString();
    }
}

