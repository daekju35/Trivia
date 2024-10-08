public class Question
{
    private string _question;
    private string[] _options;
    private string[] _correctAnswers;
    private int _points;

    public string GetQuestion { get; }
    public string[] GetOptions { get; }
    public string[] GetCorrectAnswers { get; }
    public int GetPoints { get; }

    public Question(string question, string[] options, string[] correctAnswers, int points)
    {
        _question = question;
        _options = options;
        _correctAnswers = correctAnswers;
        _points = points;
    }
}


public class Test
{
    private string _subject;
    private string _description;
    private Question[] _questions;

    public string GetSubject { get; }
    public string[] GetDescription { get; }
    public Question[] GetQuestions { get; }

    public Test(string subject, string description, Question[] questions)
    {
        _subject = subject;
        _description = description;
        _questions = questions;
    }
}

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
        if (selectedTest != null) {
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
