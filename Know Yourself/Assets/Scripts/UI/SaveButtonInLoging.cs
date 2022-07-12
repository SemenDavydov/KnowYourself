using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SaveButtonInLoging : MonoBehaviour
{
    public Button saveButton;
    void Start()
    {
        saveButton.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("Main");
    }
}
