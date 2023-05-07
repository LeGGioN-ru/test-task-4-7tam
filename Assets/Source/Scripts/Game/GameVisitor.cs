using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameVisitor : MonoBehaviour
{
    [SerializeField] private LobbyCreator _lobbyCreator;

    private CanvasGroup _canvasGroup;
    private readonly string _loadingSceneName = "Loading";

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        _lobbyCreator.Created += VisitGame;
    }

    private void OnDisable()
    {
        _lobbyCreator.Created -= VisitGame;
    }

    private void VisitGame()
    {
        _canvasGroup.interactable = false;
        SceneManager.LoadScene(_loadingSceneName);
    }
}
