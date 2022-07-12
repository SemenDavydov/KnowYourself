using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndQuestScript : MonoBehaviour
{

    public Button endQuestButton;
    

    private void Start()
    {

        Button btn = endQuestButton.GetComponent<Button>();
        btn.onClick.AddListener(EndQuest);

        void EndQuest()
        {
            if (endQuestButton == true)
            {
                ControllerLevel.countUnlockedLevel++;
                PlayerPrefs.SetInt("countLevel", ControllerLevel.countUnlockedLevel);
            }
            SceneManager.LoadScene(4);
        }
    }
}
