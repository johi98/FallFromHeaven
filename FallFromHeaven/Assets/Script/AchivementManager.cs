using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class AchivementManager : MonoBehaviour
{
    GameManager scoreManger;
    // Start is called before the first frame update
    void Start()
    {
         scoreManger = new GameManager();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.score == 20)
        {
            Social.ReportProgress(GPGSIds.achievement_20, 100f, null);
        }

        if (GameManager.score == 40)
        {
            Social.ReportProgress(GPGSIds.achievement_40, 100f, null);
        }

        if (GameManager.score == 100)
        {
            Social.ReportProgress(GPGSIds.achievement_100, 100f, null);
        }
    }
}
