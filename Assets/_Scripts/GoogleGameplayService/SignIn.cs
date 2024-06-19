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
            Destroy(gameObject);
        }
        else
        {
            Ins = this;
            DontDestroyOnLoad(gameObject);
        }
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
