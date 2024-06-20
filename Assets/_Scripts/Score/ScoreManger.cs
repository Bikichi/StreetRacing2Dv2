using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Ins; //Singletons

    public int score = 0;

    public int bestScore = 0;
    public int lastScore;

    public Text scoreText;
    public Text lastScoreText;
    public Text bestScoreText;

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

    void Start ()
    {
        LoadBestScoreValue();
    }

    void Update()
    {   
        UpdateScoreValue();
    }

    public void LoadBestScoreValue ()
    {
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
    }

    public void SaveBestScoreValue ()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("bestScore", bestScore);
            if (SignIn.Ins.isConnectedToGooglePlayServices)
            {
                Social.ReportScore(bestScore, GPGSIds.leaderboard_streetracing2d, Leaderboards.Ins.LeaderboardUpdate);

                Achievements.Ins.CheckUnlockAchievements(bestScore);
            }
        }
    }
    void UpdateScoreValue ()
    {
        lastScoreText.text = lastScore.ToString();
        bestScoreText.text = bestScore.ToString();
        scoreText.text = "Score: " + score.ToString();
    }
}
