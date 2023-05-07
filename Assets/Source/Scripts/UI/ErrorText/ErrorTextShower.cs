using DG.Tweening;
using TMPro;
using UnityEngine;

public class ErrorTextShower : MonoBehaviour
{
    public static ErrorTextShower Instance;

    [SerializeField] private TMP_Text _text;
    [SerializeField] private Color _textColor;
    [SerializeField] private float _fadeAwayDelay;
    [SerializeField] private float _fadeAwayDuration;

    private readonly float _zeroAlpha = 0;
    private Tween _fadingAway;

    private void Awake()
    {
        Instance = this;
    }

    public void Execute(string errorText)
    {
        if (_fadingAway.IsActive())
            _fadingAway.Kill();

        _text.text = errorText;
        _text.color = _textColor;

        _fadingAway = _text.DOFade(_zeroAlpha, _fadeAwayDuration).SetDelay(_fadeAwayDelay);
    }
}
