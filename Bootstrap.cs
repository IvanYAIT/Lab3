using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Clicker clicker;
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private Quit quit;

        private Score score;
        private Game game;

        private void Awake()
        {
            score = new Score();
            game = new Game(score, quit);
            scoreView.GetScore(score);
            clicker.GetScore(score);
        }
    }
}