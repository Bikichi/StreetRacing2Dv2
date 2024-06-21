using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class SignIn : MonoBehaviour
{
    public bool isConnectedToGooglePlayServices;
    public static SignIn Ins;

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
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
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
}
