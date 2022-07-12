using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoginPageScript : MonoBehaviour
{
    public Button startGameButton;
    void Start()
    {
        startGameButton.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("Registration");
    }
}
