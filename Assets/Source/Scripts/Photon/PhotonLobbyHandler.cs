using Photon.Pun;
using UnityEngine.SceneManagement;

public class PhotonLobbyHandler : MonoBehaviourPunCallbacks
{
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        ErrorTextShower.Instance.Execute("�� ������� ������� �������");
        CanvasGroupSwitcher.Instance.Enable();
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        ErrorTextShower.Instance.Execute("�� ������� ����������� � �������");
        CanvasGroupSwitcher.Instance.Enable();
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene("Loading");
    }
}
