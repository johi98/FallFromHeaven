using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndPanelManager : MonoBehaviour
{

    public Text Score;
     public Text BestScore;
    public GameObject medal;
    public Sprite Pink_S;
    public Sprite Purple_S;
    public Sprite Green_S;


    public void OnEnable()
    {
        Score.text=GameManager.score.ToString();
        if(GameManager.bestScore < GameManager.score)
        {
            GameManager.bestScore = GameManager.score;
            
        }
       BestScore.text = GameManager.bestScore.ToString();
       if (GameManager.score >=3)
        {
            medal.GetComponent<Image>().sprite = Green_S;
        }
       else if (GameManager.score >= 2)
        {
            medal.GetComponent<Image>().sprite = Purple_S;
        }
       else medal.GetComponent<Image>().sprite = Pink_S;
    }

    public void REBtn()
    {
        GameManager.score = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void EXBtn()
    {
        GameManager.score = 0;
        SceneManager.LoadScene("Main");
    }
   
}
