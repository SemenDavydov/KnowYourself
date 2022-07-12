using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Day1Button : MonoBehaviour
{
    public Button endButton;
    void Start()
    {
        endButton.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("MyWay");
    }
}
