using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonMyCoopybook : MonoBehaviour
{
    public Button myCoopybookButton;
    void Start()
    {
        myCoopybookButton.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("MyCopybook");
    }
}
