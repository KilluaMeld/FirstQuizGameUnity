using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSettings : MonoBehaviour
{
    [SerializeField] private int _attempts;
    [SerializeField] private int _correctAnswers;
    [SerializeField] private int _category;
    [SerializeField] private string _pathOnQuizList;
    [SerializeField] private GameObject _levelInformationPanel;
    [SerializeField] private Transform _forNewWindows;
    private Links links;

    //Надо создать окно промежуточное

    private void Start()
    {
        links = GameObject.FindObjectOfType<Links>();
    }

    public void StartLevel()
    {
        if (_attempts>0)
        {
            GameObject levelInformationPanel =  Instantiate(_levelInformationPanel, _forNewWindows) as GameObject;
            levelInformationPanel.GetComponent<InformationAboutLevel>().SetInformation(links.CategoryIcons[_category], links.CategoryName[_category], _attempts, _correctAnswers);
        }
    }

    public void MinusAttempt(int count)
    {
        _attempts -= count;
    }

    public void PlusAnswer(int count)
    {
        _correctAnswers += count;
    }
}
