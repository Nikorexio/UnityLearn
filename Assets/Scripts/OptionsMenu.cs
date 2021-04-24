using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : Singleton<OptionsMenu>
{
    [SerializeField] Button ReturnButton;
    [SerializeField] VolumeValue volume;

    [SerializeField] private MainMenu _mainMenu;

    void Start()
    {
        ReturnButton.onClick.AddListener(HandleReturnClicked);
    }

    void HandleReturnClicked ()
    {
        gameObject.SetActive(false);
        _mainMenu.gameObject.SetActive(true);
    }
}
