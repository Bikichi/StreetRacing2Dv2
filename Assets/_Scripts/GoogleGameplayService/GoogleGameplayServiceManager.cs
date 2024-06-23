using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;

public class GoogleGameplayServiceManager : MonoBehaviour
{
    public bool isConnectedToGooglePlayServices;
    public Text signInStatusText;

    private void Awake()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }

    private void Update()
    {
        signInStatusText.text = isConnectedToGooglePlayServices.ToString();
    }

    public void Start()
    {
        LoginGooglePlay();
    }
    public void LoginGooglePlay()
    {
        Debug.Log("LOGIN!!!");
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }
    public void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            isConnectedToGooglePlayServices = true;
        }
        else isConnectedToGooglePlayServices = false;
    }

    public void LeaderboardUpdate(bool success)
    {
        if (success) Debug.Log("Updated Leaderboard");
        else Debug.Log("Faild to update Leaderboard");
    }

    public void ShowLeaderboard()
    {
        Debug.Log("Button pressed - attempting to show leaderboard.");
        if (isConnectedToGooglePlayServices)
        {
            Debug.Log("Show Leaderboard UI !!!");
            PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_streetracing2d);
        }
        else
        {
            Debug.Log("Not connected to Google Play Services.");
        }
    }

    public void CheckUnlockAchievements(int bestScore)
    {
        if (bestScore >= 100)
        {
            UnlockHaveBestScoreIs100Achievement();
        }
        else if (bestScore >= 200)
        {
            UnlockHaveBestScoreIs200Achievement();
        }
        else if (bestScore >= 300)
        {
            UnlockHaveBestScoreIs300Achievement();
        }
    }

    public void UnlockHaveBestScoreIs100Achievement()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_have_best_score_is_100, 100.0f, (bool success) => {
        });
    }

    public void UnlockHaveBestScoreIs200Achievement()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_have_best_score_is_200, 100.0f, (bool success) => {
        });
    }

    public void UnlockHaveBestScoreIs300Achievement()
    {
        PlayGamesPlatform.Instance.ReportProgress(GPGSIds.achievement_have_best_score_is_300, 100.0f, (bool success) => {
        });
    }

    public void ShowAchievements()
    {
        Debug.Log("Button pressed - attempting to show achievements.");
        if (isConnectedToGooglePlayServices)
        {
            Debug.Log("Show Achievements UI !!!");
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        else
        {
            Debug.Log("Not connected to Google Play Services.");
        }
    }
}
