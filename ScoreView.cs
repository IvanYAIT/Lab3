using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textScore;
    private Score score;

    public void SetScore(Score score)
    {
        this.score = score;
    }

    void Update()
    {
        textScore.text = $"{score.PlayerScore}";
    }
}
