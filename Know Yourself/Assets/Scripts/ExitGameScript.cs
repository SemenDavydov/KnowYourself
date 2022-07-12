using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitGameScript : MonoBehaviour
{
    public Button ExitGameButton;

    public void ExitGame()
    {
        Application.Quit();
    } 
}
