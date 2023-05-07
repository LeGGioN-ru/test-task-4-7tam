using Photon.Pun;

public class LobbyFinder : Lobby
{
    protected override void ProcessLobby()
    {
        PhotonNetwork.JoinRoom(LobbyName);
    }
}
