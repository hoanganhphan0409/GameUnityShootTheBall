using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public GameObject Pannel;
    public void showScore(string txt)
    {
        if (scoreText!= null) scoreText.text = txt;
    }
    public void showPannel(bool isShow)
    {
        if (Pannel != null) Pannel.SetActive(isShow);
    }
}
