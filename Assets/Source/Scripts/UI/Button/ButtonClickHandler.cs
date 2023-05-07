using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    private Button _button;
    private IButtonClickable[] _clickables;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _clickables = GetComponents<IButtonClickable>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        if (_clickables.Length == 0)
        {
            ErrorTextShower.Instance.Execute("1");
            return;
        }

        foreach (IButtonClickable clickable in _clickables)
            clickable.OnClick();
    }
}
