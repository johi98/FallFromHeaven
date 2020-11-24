using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;

public class GPGSManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
        // requests the email address of the player be available.
        // Will bring up a prompt for consent.
        .RequestEmail()
        // requests a server auth code be generated so it can be passed to an
        //  associated back end server application and exchanged for an OAuth token.
        .RequestServerAuthCode(false)
        .Build();

        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();

        Login();
    }

    void Login()
    {
        if (Social.localUser.authenticated)
        {
            Debug.Log("이미 로그인된 유저");
        }
        else
        {
            Social.localUser.Authenticate((bool success) =>
            {
                if (success)
                {
                    Debug.Log("로그인 성공");

                }
                else
                {
                    Debug.Log("로그인 실패");
                }
            });
        }
    }

    public void ShowReaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void ShowAchievement()
    {
        Social.ShowAchievementsUI();
    }

    public void AddAchievement()
    {
        Social.ReportProgress("CgkIi5vQyKAGEAIQAQ", 100.0f, (bool success) => {
            // handle success or failure
        });
    }

    public void AddScore()
    {
        Social.ReportScore(12345, "CgkIi5vQyKAGEAIQAg", (bool success) => {
            // handle success or failure
        });
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }



    // Update is called once per frame
    void Update()
    {

    }
}
