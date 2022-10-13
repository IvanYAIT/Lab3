using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Clicker clicker;
        [SerializeField] private NewClicker newclicker;
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private InputListaner inputListaner;

        private Score score;
        private Game game;

        private void Awake()
        {
            score = new Score();
            game = new Game(score, inputListaner);
            scoreView.SetScore(score);
            clicker.SetScore(score);
            newclicker.SetScore(score);
        }
    }
}