using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMode : Singleton<UIMode>
{
    public void OnChange()
    {
        if (GetComponent<Slider>().value == 1)
        BackgroundMode.Instance._image.color = Color.HSVToRGB(0.752f,0.86f,0.49f);    //0x4A127E;
        if (GetComponent<Slider>().value == 0)
        BackgroundMode.Instance._image.color = Color.white;
    }
}
