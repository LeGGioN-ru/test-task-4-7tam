using TMPro;
using UnityEngine;

public abstract class Lobby : MonoBehaviour, IButtonClickable
{
    [SerializeField] private TMP_InputField _lobbyNameInput;

    protected string LobbyName => _lobbyNameInput.text;

    public void OnClick()
    {
        if (IsLobbyNameCorrect())
            ProcessLobby();

        CanvasGroupSwitcher.Instance.Disable();
    }

    private bool IsLobbyNameCorrect()
    {
        if (string.IsNullOrEmpty(_lobbyNameInput.text))
        {
            ErrorTextShower.Instance.Execute("Название лобби не может быть пустым");
            return false;
        }

        return true;
    }

    protected abstract void ProcessLobby();
}
