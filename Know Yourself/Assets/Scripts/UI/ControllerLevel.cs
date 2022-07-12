using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ControllerLevel : MonoBehaviour
{
    public static int countUnlockedLevel = 1;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("countLevel"))
        {
            countUnlockedLevel = PlayerPrefs.GetInt("countLevel");
        }      
    }

    void Start()
    {

        for (int i = 0; i < transform.childCount; i++)
            {
                if (i < countUnlockedLevel)
                {
                    #region FirstStateBtn
                    transform.GetChild(i).GetComponent<Button>().interactable = true;
                    #endregion
            }
                else
                {
                    #region SndStateBtn
                    transform.GetChild(i).GetComponent<Button>().interactable = false;
                    #endregion
                }  
            }
    }
}
