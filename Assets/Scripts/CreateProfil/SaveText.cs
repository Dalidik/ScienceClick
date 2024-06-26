using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveText : MonoBehaviour
{
    public TextMeshProUGUI obj_text;
    public TextMeshProUGUI second_text;
    public TMP_InputField display;
    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
        second_text.text = PlayerPrefs.GetString("user_name");
    }

    public void Create()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        second_text.text = display.text;
        PlayerPrefs.SetString("user_name", second_text.text);
        PlayerPrefs.Save();
        
    }
   

}
