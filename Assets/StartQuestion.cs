using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class StartQuestion : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _question;
    [SerializeField] private QuiestionList1 _ql;
    [SerializeField] private List<AnswerOnButton> _answersButton;

    private QuiestionList1 li1 = new QuiestionList1 (); 
    private void Start()
    {
        TakeAndSetQuestion();
    }
    void TakeAndSetQuestion()
    {
        var l = li1.SendQuestion();
        SetQuestion(l.quest);
        SetAnswers(l.answers);
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
