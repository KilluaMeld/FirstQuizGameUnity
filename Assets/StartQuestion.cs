using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.IO;

public class StartQuestion : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _question;
    //[SerializeField] private QuiestionList1 _ql;
    [SerializeField] private List<AnswerOnButton> _answersButton;

    private QuiestionList1 li1 = new QuiestionList1 (); 
    private void Start()
    {
        TakeAndSetQuestion();
    }
    [SerializeField] QuestionInJsonList _ql = new QuestionInJsonList();
    void TakeAndSetQuestion()
    {
        _ql = JsonUtility.FromJson<QuestionInJsonList>(File.ReadAllText(Application.streamingAssetsPath + "/QuestionsList.json"));
        //var l = li1.SendQuestion();
        SetQuestion(_ql.QuestionList22[0].Question);
        SetAnswers(new List<string>{ _ql.QuestionList22[0].answer1, _ql.QuestionList22[0].answer2, _ql.QuestionList22[0].answer3, _ql.QuestionList22[0].answer4, });
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
    public List<QuestionInJson> QuestionList22;
}