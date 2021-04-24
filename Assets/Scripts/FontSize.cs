using UnityEngine.UI;

public class FontSize : Singleton<FontSize>
{

    public void OnChange()
    {
        for (int i = 0; i < TextAccess.Instance._text.Length; i++)
        {
            TextAccess.Instance._text[i].fontSize = GetComponent<Slider>().value;
        }
        
    }

}
