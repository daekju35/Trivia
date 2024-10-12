using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Trivia
    {
        private CollectionOfTests _collectionOfTests;
        private Test _currentTest;
        private int _indexOfTest;
        public CollectionOfTests GetCollectionOfTests { get; }
        public Test GetTest { get; }

        public int GetResult(int result)
        {
            return result;
        }

        public int GetScore(int score)
        {
            return score;
        }

        public void ShowNextQuestion()
        {

        }

        public void CheckAnswers(string[] correctAnswers, string[] userAnswers)
        {
        }

        public void ShowTests()
        {

        }
    }

}
