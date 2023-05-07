using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class CanvasGroupSwitcher : MonoBehaviour
{
    public static CanvasGroupSwitcher Instance;

    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        Instance = this;

        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Enable()
    {
        _canvasGroup.interactable = true;
    }

    public void Disable()
    {
        _canvasGroup.interactable = false;
    }
}
