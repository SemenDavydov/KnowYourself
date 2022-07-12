using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;

public class ListtextScript : MonoBehaviour
{
    [SerializeField] RectTransform textRT;
    [SerializeField] RectTransform contentRT;
    public TMP_InputField inputText;
    public Button SaveTextButton;
    public TMP_Text  textDisplay;
    public List<string> savingText = new List<string>();

    private void Awake()
    {
        if (PlayerPrefs.HasKey("savingText"))
        {
            savingText = PlayerPrefs.GetString("savingText");  
        }
    }

    void Update()
    {
        var size = contentRT.sizeDelta;
        size.y = textRT.sizeDelta.y;
        contentRT.sizeDelta = size;
    }

    public void SavingTextButton()
    {
        savingText.Add(inputText.text);
        textDisplay.text = "";
        foreach (string i in savingText)
        {
            textDisplay.text += i + "\n";
            PlayerPrefs.SetString("savingText", savingText.ToString()); 
        }       
    }
}
