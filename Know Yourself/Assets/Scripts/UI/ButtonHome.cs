using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonHome : MonoBehaviour
{
    public Button buttonHome;
    void Start()
    {
        buttonHome.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("Main");
    }
}
