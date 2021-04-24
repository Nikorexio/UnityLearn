using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FontColor : Singleton<FontColor>
{
    public string selection;
    void Start()
    {
        selection = "Red";
    }

    public void OnChange()
    {
        selection = GetComponent<TMP_Dropdown>().captionText.text;
        switch(selection)
        {
            case "Red":
                for (int i = 0; i < TextAccess.Instance._text.Length; i++)
                {
                    TextAccess.Instance._text[i].color = Color.red;
                }
                break;
            case "Green":
                for (int i = 0; i < TextAccess.Instance._text.Length; i++)
                {
                    TextAccess.Instance._text[i].color = Color.green;
                }
                break;
            case "Blue":
                for (int i = 0; i < TextAccess.Instance._text.Length; i++)
                {
                    TextAccess.Instance._text[i].color = Color.blue;
                }
                break;
        }
    }
}
