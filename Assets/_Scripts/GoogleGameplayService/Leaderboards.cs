using UnityEngine;


public class Leaderboards : MonoBehaviour
{
    public static Leaderboards Ins { get; private set; }

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
    public void LeaderboardUpdate(bool success)
    {
        if (success) Debug.Log("Updated Leaderboard");
        else Debug.Log("Faild to update Leaderboard");
    }

    public void ShowLeaderboard()
    {
        Debug.Log("Show Leaderboard UI !!!");
        Social.ShowLeaderboardUI();
    }
}
