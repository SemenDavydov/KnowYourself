using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonMyWay : MonoBehaviour
{
    public Button myWayButton;
    void Start()
    {
        myWayButton.onClick.AddListener(delegate
        {
            login();
        });
    }
    private void login()
    {
        SceneManager.LoadScene("MyWay");
    }
}
