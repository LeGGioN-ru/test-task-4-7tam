using Photon.Pun;
using UnityEngine;

public class PhotonInitializator : MonoBehaviour
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
}
