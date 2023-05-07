using Photon.Pun;
using System;

public class LobbyFinder : Lobby
{
    protected override void ProcessLobby()
    {
        PhotonNetwork.JoinRoom(LobbyName);
    }
}
