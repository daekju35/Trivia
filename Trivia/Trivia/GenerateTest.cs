using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class GenerateTest
    {
        private CollectionOfTests _collectionOfTests;

        public void GetRandomTest()
        {
            Random randomIndex = new Random();
            Test[] tests = _collectionOfTests.Tests.ToArray();
            _collectionOfTests.GetTest(randomIndex.Next(0, tests.Length));
        }
    }
}
