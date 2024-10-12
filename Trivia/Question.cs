

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