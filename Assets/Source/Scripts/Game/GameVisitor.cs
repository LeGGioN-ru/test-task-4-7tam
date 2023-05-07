using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameVisitor : MonoBehaviour
{
    [SerializeField] private ServerCreator _serverCreator;

    private CanvasGroup _canvasGroup;
    private readonly string _loadingSceneName = "Loading";

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        _serverCreator.Created += VisitGame;
    }

    private void OnDisable()
    {
        _serverCreator.Created -= VisitGame;
    }

    private void VisitGame()
    {
        _canvasGroup.interactable = false;
        SceneManager.LoadScene(_loadingSceneName);
    }
}
