using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Clicker : MonoBehaviour
    {
        Score score;

        public void SetScore(Score score)
        {
            this.score = score;
        }

        private void MinusPointsToScore()
        {
            score.PlayerScore -= 1;
        }


        private void OnMouseDown()
        {
            MinusPointsToScore();
        }
    }
}
