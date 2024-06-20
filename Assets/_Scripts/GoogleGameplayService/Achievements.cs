using UnityEngine;

public class Achievements : MonoBehaviour
{
    public static Achievements Ins { get; private set; }

    private void Awake()
    {
        if (Ins != null && Ins != this)
        {
            Destroy(Ins);
        }
        else
        {
            Ins = this;
        }
    }

    public void CheckUnlockAchievements(int bestScore)
    {
        switch (bestScore)
        {
            case 100:
                UnlockHaveBestScoreIs100Achievement();
                break;
            case 200:
                UnlockHaveBestScoreIs200Achievement();
                break;
            case 300:
                UnlockHaveBestScoreIs300Achievement();
                break;
        }

    }   

    public void UnlockHaveBestScoreIs100Achievement()
    {
        Social.ReportProgress(GPGSIds.achievement_have_best_score_is_100, 100.0f, (bool success) => {
        });
    }

    public void UnlockHaveBestScoreIs200Achievement()
    {
        Social.ReportProgress(GPGSIds.achievement_have_best_score_is_200, 100.0f, (bool success) => {
        });
    }

    public void UnlockHaveBestScoreIs300Achievement()
    {
        Social.ReportProgress(GPGSIds.achievement_have_best_score_is_300, 100.0f, (bool success) => {
        });
    }

    public void ShowAchievements()
    {
        if (!SignIn.Ins.isConnectedToGooglePlayServices) SignIn.Ins.LoginGooglePlay();
        Debug.Log("Show Achievements UI !!!");
        Social.ShowAchievementsUI();
    }
}
