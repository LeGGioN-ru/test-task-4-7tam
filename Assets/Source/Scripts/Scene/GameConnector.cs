using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConnector : MonoBehaviour
{
    private readonly string _gameSceneName = "Game";

    private void Start()
    {
        if (PhotonNetwork.InRoom)
            SceneManager.LoadScene(_gameSceneName);
    }
}
