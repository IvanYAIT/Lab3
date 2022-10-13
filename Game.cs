using ScoreSystem;

namespace Core
{
    public class Game
    {
        private const int scorePoint = 5;
        private Score score;
        private InputListaner quit;
        public Game(Score score, InputListaner quit)
        {
            this.quit = quit;
            this.score = score;
            StartGame();
        }

        private void StartGame()
        {
            score.PlayerScore = scorePoint;
            quit.onExitAction += QuitGame;
        }

        private void QuitGame()
        {
            score.PlayerScore = 0;

            quit.onExitAction -= QuitGame;
        }

       
    }
}

