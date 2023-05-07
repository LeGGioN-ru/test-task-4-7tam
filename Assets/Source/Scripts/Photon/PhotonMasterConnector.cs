using ExitGames.Client.Photon;
using Photon.Pun;
using System;
using UnityEngine.SceneManagement;

public class PhotonMasterConnector : MonoBehaviourPunCallbacks
{
    private readonly string _lobbyName = "Lobby";

    private void Start()
    {
        if (PhotonNetwork.IsConnected == false)
            PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene(_lobbyName);
    }
}
