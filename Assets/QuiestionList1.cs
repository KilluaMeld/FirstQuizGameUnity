using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuiestionList1 : MonoBehaviour
{
    lis[] li = new lis[]{
        new lis("ѕоследовательное изложение самим говор€щим или пишущим основных этапов его жизни", new List<string>{ "автобиографи€", "q", "q", "q" }),
        new lis("ћузыкальное сопровождение сольной вокальной или инструментальной партии, основной темы или мелодии музыкального произведени€", new List<string>{ "аккомпанемент", "q", "q", "q" }),
        new lis("—истема взгл€дов на развитие органического мира, отрицающа€ биологическую эволюцию вообще или учение о естественном отборе", new List<string>{ "антидарвинизм", "q", "q", "q" }),
        new lis("—троительство барж", new List<string>{ "баржестроение", "q", "q", "q" }),
        new lis("Ќедостаток художественной образности (в произведении искусства, литературы)", new List<string>{ "безобразность", "q", "q", "q" }) 
    };  

    public lis SendQuestion()
    {
        return li[Random.Range(0, li.Length)];
    }
}
public class lis
{
    public string quest;
    public List<string> answers;

    public lis(string quest, List<string> answers)
    {
        this.quest = quest;
        this.answers = answers;
    }
}
