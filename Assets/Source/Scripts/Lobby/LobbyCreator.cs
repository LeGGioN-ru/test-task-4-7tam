using Photon.Pun;

public class LobbyCreator : Lobby
{
    protected override void ProcessLobby()
    {
        PhotonNetwork.CreateRoom(LobbyName);
    }
}
