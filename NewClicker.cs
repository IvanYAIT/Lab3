using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class NewClicker : MonoBehaviour
    {
        Score score;
        private JointMotor motor;
        private bool isOnRight;

        private void Start()
        {
            motor = gameObject.GetComponent<HingeJoint>().motor;
            isOnRight = true;
        }

        private void Update()
        {
            
            if (transform.position.x >= 1.9 && isOnRight)
            {
                isOnRight = false;
                motor.targetVelocity = 100;
                Debug.Log(motor.targetVelocity);
            } else if(transform.position.x <= -1.9 && !isOnRight)
            {
                motor.targetVelocity = -100;
                isOnRight = true;
                Debug.Log(motor.targetVelocity);
            }
            gameObject.GetComponent<HingeJoint>().motor = motor;
        }

        public void SetScore(Score score)
        {
            this.score = score;
        }

        private void AddPointsToScore()
        {
            score.PlayerScore += 1;
        }

        private void OnMouseDown()
        {
            AddPointsToScore();
        }
    }
}

