using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPreparetion_demo
{
    public class Process
    {
        static List<List<Question>> questionList = new List<List<Question>>(); //読み込み用リスト
        /// <summary>
        /// テキストファイルから問題を読み込み
        /// リストに保存する
        /// </summary>
        public static Question LoadQuestion(int questionId)
        {
            
            Question result = new Question(); //戻り値

            //テキストファイルから問題を抽出
            using (StreamReader file = new StreamReader("C:\\Users\\kouki\\source\\repos\\Demo\\examPreparetion_demo\\examPreparetion_demo\\Database\\Question.txt", System.Text.Encoding.UTF8))
            {
                try
                {
                    string line = "";
                    string[] splitLine;
                    List<Question> list = new List<Question>();


                    //question.txtを1行ずつ読み込み、末端まで繰り返す
                    //問題文, 解答1, 解答2, 解答3, 解答4, 正解解答番号の順でリスト化する
                    while ((line = file.ReadLine()) != null)
                    {
                        try
                        {
                            splitLine = line.Split(',');
                            Question q = new Question();
                            q.questionStatement = splitLine[0];
                            q.answer1 = splitLine[1];
                            q.answer2 = splitLine[2];
                            q.answer3 = splitLine[3];
                            q.answer4 = splitLine[4];
                            q.correctAnswer = int.Parse(splitLine[5]);
                            list.Add(q);
                            questionList.Add(list);
                        }
                        catch
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }

            result.questionStatement = questionList[0][questionId].questionStatement;
            result.answer1 = questionList[0][questionId].answer1;
            result.answer2 = questionList[0][questionId].answer2;
            result.answer3 = questionList[0][questionId].answer3;
            result.answer4 = questionList[0][questionId].answer4;
            result.correctAnswer = questionList[0][questionId].correctAnswer;

            return result;
        }
    }

    /// <summary>
    /// questionStatement：問題文
    /// answer1：解答①
    /// answer2：解答②
    /// answer3：解答③
    /// answer4：解答④
    /// correctAnswer：正解番号
    /// </summary>
    public class Question
    {
        public string? questionStatement { get; set; }
        public string? answer1 { get; set; }
        public string? answer2 { get; set; }
        public string? answer3 { get; set; }
        public string? answer4 { get; set; }
        public int correctAnswer { get; set; }
    }
}
