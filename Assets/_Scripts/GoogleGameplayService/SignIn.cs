using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class SignIn : MonoBehaviour
{
    public bool isConnectedToGooglePlayServices;

    private void Awake()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }
    void Start()
    {
        LoginGooglePlay();
    }
    void LoginGooglePlay()
    {
        Debug.Log("LOGIN!!!");
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }
    void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            isConnectedToGooglePlayServices = true;
        }
        else isConnectedToGooglePlayServices = false;
    }
}
