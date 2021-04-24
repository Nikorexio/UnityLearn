using UnityEngine;
using UnityEngine.UI;


public class MainMenu : Singleton<MainMenu>
{

    [SerializeField] private Button StartButton;
    [SerializeField] private Button OptionsButton;
    [SerializeField] private Button QuitButton;

    [SerializeField] private OptionsMenu _optionsMenu;

    void Start()
    {

        StartButton.onClick.AddListener(HandleStartClicked);
        OptionsButton.onClick.AddListener(HandleOptionsClicked);
        QuitButton.onClick.AddListener(QuitButtonClicked);
    }

    void HandleStartClicked()
    {
        GameManager.Instance.StartGame();
    }

    void HandleOptionsClicked()
    {
        _optionsMenu.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    void QuitButtonClicked()
    {
        GameManager.Instance.QuitGame();
    }
}
