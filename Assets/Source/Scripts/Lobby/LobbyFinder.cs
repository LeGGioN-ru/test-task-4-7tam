using Photon.Pun;
using System;

public class LobbyFinder : Lobby
{
    public Action Finded;

    protected override void ProcessLobby()
    {
        PhotonNetwork.JoinRoom(LobbyName);
        Finded?.Invoke();
    }
}
