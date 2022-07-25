using System.Collections;
using UnityEngine;
using TMPro;

public class AnswerOnButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _answersText; 
    [SerializeField] bool _trueAnswer;
    
    public void SetValue(string text, bool answer)
    {
        _answersText.text = text;
        _trueAnswer = answer;
    }
    public void ResultAnswer()
    {
        if (_trueAnswer)
            Debug.Log("True");
        else
            Debug.Log("False");
    }
}
