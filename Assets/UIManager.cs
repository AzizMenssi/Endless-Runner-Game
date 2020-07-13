using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIManager : MonoBehaviour
{
    public List<UINumber> score;
    public List<Sprite> numbers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score.Count == 0 || numbers.Count == 0)
        {
            return;
        }
        score[0].value = (int)GameManager.score / 1000;
        score[1].value = ((int)GameManager.score / 100)%10;
        score[2].value = ((int)GameManager.score / 10)%10;
        score[3].value = (int)GameManager.score % 10;
        for(int i = 0; i < score.Count; i++)
        {
            score[i].img.sprite = numbers[score[i].value];
        }

    }
}
