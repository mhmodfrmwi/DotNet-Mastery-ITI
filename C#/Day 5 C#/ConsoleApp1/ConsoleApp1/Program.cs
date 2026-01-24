using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
       struct Examination
        {
            public void ProcessExamResult(string studentName ,in double rawFinalScore,out double normalizedFinalScore,in double labScore, out char grade , string institution = "menofia",params double[] examScores)
            {

                normalizedFinalScore= rawFinalScore + labScore;
                grade = normalizedFinalScore >= 90 ? 'A' : normalizedFinalScore >= 80 ? 'B' : normalizedFinalScore >= 70 ? 'C' : normalizedFinalScore >= 50 ? 'D' : 'F';
                double sum = 0;
                for (int i = 0; i < examScores.Length; i++)
                {
                    sum += examScores[i];
                }
                if (sum!=rawFinalScore)
                {
                    throw new Exception("exam scores not equal final row");
                }
                Console.WriteLine($"{studentName} is in {institution}, his grade is {grade} his degree in the exam = {rawFinalScore} and his total score = {normalizedFinalScore}");
            }

        }
        static void Main(string[] args)
        {
            Examination ex;
            double rawFinalScore = 60;
            double labscore = 30;
            double normalizedFinalScore;
            char grade;
            ex.ProcessExamResult("Mahmoud", in rawFinalScore, out normalizedFinalScore, in labscore, out grade, "Menofia", 20, 20, 20);
        }
    }
}
