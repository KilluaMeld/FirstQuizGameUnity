using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InformationAboutLevel : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _category;
    [SerializeField] private TextMeshProUGUI _attemptsCount;
    [SerializeField] private TextMeshProUGUI _correctAnswers;

    public void SetInformation(Sprite icon, string category, int attemptsCount, int correctAnswers)
    {
        _icon.sprite = icon;
        _category.text = category;
        _attemptsCount.text = attemptsCount.ToString();
        _correctAnswers.text = correctAnswers.ToString();
    }
    
    public void DestroyThisGameObject()
    {
        Destroy(this.gameObject);
    }
    public void PlayLevel()
    {
        GameObject.FindObjectOfType<Links>().QuizPanel.SetActive(true);
        Destroy(this.gameObject);
    }
}
