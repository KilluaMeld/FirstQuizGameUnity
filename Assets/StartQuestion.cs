using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.IO;

public class StartQuestion : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _question;
    [SerializeField] private List<AnswerOnButton> _answersButton;
    [SerializeField] QuestionInJsonList _ql = new QuestionInJsonList();

    private void Start()
    {
    }
    public void TakeQuizList(string pathOnQuizList)
    {
        _ql = JsonUtility.FromJson<QuestionInJsonList>(File.ReadAllText(Path.Combine(Application.streamingAssetsPath, pathOnQuizList)));
    }
    void SetQuiz()
    {
        var rand = Random.Range(0, _answersButton.Count);
        SetQuestion(_ql.QuestionList[rand].Question);
        SetAnswers(new List<string>{ _ql.QuestionList[rand].answer1, _ql.QuestionList[rand].answer2, _ql.QuestionList[rand].answer3, _ql.QuestionList[rand].answer4});
        _ql.QuestionList.RemoveAt(rand);
    }
    void SetQuestion(string text)
    {
        _question.text = text;
    }
    void SetAnswers(List<string> answers)
    {
        for (int i = 0; i < answers.Count; i++)
        {
            var rand = Random.Range(0, _answersButton.Count);
            if (i==0)
            {
                _answersButton[rand].SetValue(answers[i], true);
            }
            else
            {
                _answersButton[rand].SetValue(answers[i], false);
            }
            _answersButton.RemoveAt(rand);
        }
    }

}

[System.Serializable]
class QuestionInJson
{
    public string Question;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
}

[System.Serializable]
class QuestionInJsonList
{
    public List<QuestionInJson> QuestionList;
}