using Photon.Pun;
using System;
using TMPro;
using UnityEngine;

public class ServerCreator : MonoBehaviour, IButtonClickable
{
    [SerializeField] private TMP_InputField _lobbyName;

    public Action Created;

    public void OnClick()
    {
        CreateRoom();
    }

    private void CreateRoom()
    {
        if (string.IsNullOrEmpty(_lobbyName.text))
        {
            ErrorTextShower.Instance.Execute("Название лобби не может быть пустым");
            return;
        }

        PhotonNetwork.CreateRoom(_lobbyName.text);
        Created?.Invoke();
    }
}
