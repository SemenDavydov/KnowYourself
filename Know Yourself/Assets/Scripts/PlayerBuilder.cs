using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBuilder : MonoBehaviour
{
    [SerializeField] private Material mainR, secondR, thierdR;
    [SerializeField] private TMP_Text nicknameT;
    
    
    
    public void ChangeMainColor(Palette color)
    {
        mainR.color = color.GetColor();
        WebManager.userData.playerData.SetMainColor(JsonUtility.ToJson(color.GetColor()));
    }
    public void ChangeSecondColor(Palette color)
    {
        secondR.color = color.GetColor();
        WebManager.userData.playerData.SetSecondColor(JsonUtility.ToJson(color.GetColor()));
    }

    public void ChangeThierdColor(Palette color)
    {
        thierdR.color = color.GetColor();
        WebManager.userData.playerData.SetThierdColor(JsonUtility.ToJson(color.GetColor()));
    }
    public void ChangeNickName(TMP_Text newName)
    {
        nicknameT.text = newName.text;
        WebManager.userData.playerData.nickname = newName.text;
    }
}
