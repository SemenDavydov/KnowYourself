using UnityEngine;

public class BackgroundSoundController : MonoBehaviour
{
    private bool isMute;
    [Header("Tags")]
    [SerializeField] private string createdTag;
    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(this.createdTag);
        if(obj != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = this.createdTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        isMute = PlayerPrefs.GetInt("Mute") == 1;
        AudioListener.pause = isMute;
    }

    public void MuteButton()
    {
        isMute = !isMute;
        AudioListener.pause = isMute;
        PlayerPrefs.SetInt("Mute", isMute ? 1 : 0);
    }
}
