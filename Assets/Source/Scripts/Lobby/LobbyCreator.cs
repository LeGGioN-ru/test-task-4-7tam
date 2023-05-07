using Photon.Pun;
using System;

public class LobbyCreator : Lobby
{
    public Action Created;

    protected override void ProcessLobby()
    {
        PhotonNetwork.CreateRoom(LobbyName);
        Created?.Invoke();
    }
}
