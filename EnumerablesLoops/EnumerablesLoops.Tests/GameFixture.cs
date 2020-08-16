using EnumerablesArrays.Common;
using NUnit.Framework;

namespace EnumerablesLoops.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAppIsStarting_UserCanStartGame()
        {
            var game = new Game();
            game.Start();
            var isStarted = game.IsGameReady();
            Assert.AreEqual(true, isStarted);
        }

        [Test]
        public void WhenAppIsStarting_UserCanNotStartGameIfNumberIsNotReady()
        {
            var game = new Game();
            var isStarted = game.IsGameReady();
            Assert.AreEqual(false, isStarted);
        }

        [Test]
        public void UserCanNotPredict_WhenGameIsNotStarted()
        {
            var game = new Game();
            var result = game.Predict(10);
            Assert.AreEqual(PredictionResult.Error, result);
        }

        [Test]
        public void WhenUserPredictsANumber_Gets_Up_AsResult()
        {
            var game = new Game();
            game.Start(75);
            var result = game.Predict(50);
            Assert.IsTrue(result == PredictionResult.Up);
        }

        [Test]
        public void WhenUserPredictsANumber_Gets_Down_AsResult()
        {
            var game = new Game();
            game.Start(40);
            var result = game.Predict(50);
            Assert.IsTrue(result == PredictionResult.Down);
        }

        [Test]
        public void WhenUserPredictsANumber_Gets_Correct_AsResult()
        {
            var game = new Game();
            game.Start(40);
            var result = game.Predict(40);
            Assert.IsTrue(result == PredictionResult.Correct);
        }

        [Test]
        public void PlayAProperGame()
        {
            var game = new Game();
            game.Start(75);
            var p1 = game.Predict(40);
            Assert.AreEqual(PredictionResult.Up, p1);
            var p2 = game.Predict(60);
            Assert.AreEqual(PredictionResult.Up, p2);
            var p3 = game.Predict(70);
            Assert.AreEqual(PredictionResult.Up, p3);
            var p4 = game.Predict(90);
            Assert.AreEqual(PredictionResult.Down, p4);
            var p5 = game.Predict(80);
            Assert.AreEqual(PredictionResult.Down, p5);
            var p6 = game.Predict(75);
            Assert.AreEqual(PredictionResult.Correct, p6);
        }

        [Test]
        public void WhenUserCheats_IGetTrueFromCheatMode()
        {
            var game = new Game();
            game.Start(45);
            var isCheating = game.IsCheatMode();
            Assert.AreEqual(true, isCheating);
        }

        [Test]
        public void WhenUserStartsProperly_IGetFalseFromCheatMode()
        {
            var game = new Game();
            game.Start();
            var isCheating = game.IsCheatMode();
            Assert.AreEqual(false, isCheating);
        }

        [Test]
        public void UserCanFinishGame()
        {
            var game = new Game();
            game.Start(50);
            game.Predict(10);
            game.Predict(20);
            game.Predict(30);
            game.Finish();
            var isReady = game.IsGameReady();
            var isCheatMode = game.IsCheatMode();
            var attemptCount = game.GetAttemptCount();

            Assert.IsFalse(isReady);
            Assert.IsFalse(isCheatMode);
            Assert.AreEqual(0, attemptCount);
        }

        [Test]
        public void UserCanGet_AttemptCount()
        {
            var game = new Game();
            game.Start(50);
            game.Predict(10);
            game.Predict(20);
            game.Predict(30);
            var attemptCount = game.GetAttemptCount();
            Assert.AreEqual(3, attemptCount);
        }
    }
}