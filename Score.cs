using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScoreSystem
{
    public class Score
    {
        private int playerScore;
        public int PlayerScore
        {
            get => playerScore;
            set
            {
                playerScore = value;
            }
        }
    }
}
