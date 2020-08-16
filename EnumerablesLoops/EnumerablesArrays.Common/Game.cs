using System;

namespace EnumerablesArrays.Common
{
    public class Game
    {
        private byte attemptCount = 0;
        private bool isCheatMode = false;
        private byte number = 0;
        public void Start()
        {
            var rnd = new Random();
            number = (byte)rnd.Next(1, 100);
        }

        public void Start(byte number)
        {
            this.number = number;
            isCheatMode = true;
        }

        public byte GetAttemptCount()
        {
            return attemptCount;
        }

        public bool IsGameReady()
        {
            return number > 0;
        }

        public bool IsCheatMode()
        {
            return isCheatMode;
        }

        public PredictionResult Predict(byte number)
        {
            if (!IsGameReady() || number <= 0)
            {
                return PredictionResult.Error;
            }

            attemptCount++;
            if (number < this.number)
            {
                return PredictionResult.Up;
            }
            else if (number > this.number)
            {
                return PredictionResult.Down;
            }
            else
            {
                return PredictionResult.Correct;
            }
        }

        public void Finish()
        {
            attemptCount = 0;
            number = 0;
            isCheatMode = false;
        }
    }
}
