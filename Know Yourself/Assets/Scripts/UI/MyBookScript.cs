using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MyBookScript : MonoBehaviour
{
    public Button myBookButton;
    void Start()
    {
        myBookButton.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("MyBook");
    }
}
