using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class CollectionOfTests
    {
        private Test _test;
        private List<Test> _tests = new List<Test>();

        public Test CurrentTest { get; }
        public List<Test> Tests { get; }

        public void AddTest(Test test)
        {
            _tests.Add(test);
        }

        public Test GetTest(int testNumber)
        {

            Test selectedTest = _tests[testNumber - 1];
            if (selectedTest != null)
            {
                throw new NullReferenceException($"The test with ID number {testNumber} was not found");
            }
            return selectedTest;
        }

        public List<Test> GetTests(int start, int stop)
        {
            List<Test> selectedTests = new List<Test>();
            if (start > stop)
            {
                throw new ArgumentOutOfRangeException("This is an invalid range");
            }
            for (int i = start; i <= stop; i++)
            {
                selectedTests.Add(_tests[i]);
            }
            return selectedTests;
        }

        public void RemoveTest(int testNumber)
        {
            if (_tests[testNumber - 1] != null)
            {
                throw new NullReferenceException($"The test with ID number {testNumber} was not found");
            }
            _tests.RemoveAt(testNumber - 1);
        }
    }
}
