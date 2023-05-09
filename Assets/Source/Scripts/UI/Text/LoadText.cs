using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class LoadText : MonoBehaviour
{
    [SerializeField] private float _addCharDelay;
    [SerializeField] private int _amountAddChar;

    private TMP_Text _text;
    private int _currentAmountChars;
    private readonly char _additionChar = '.';
    private WaitForSeconds _delay;
    private string _startText;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        _delay = new WaitForSeconds(_addCharDelay);
        _startText = _text.text;
    }

    private void Start()
    {
        StartCoroutine(Loading());
    }

    private IEnumerator Loading()
    {
        _text.text = _startText;

        while (_currentAmountChars != _amountAddChar)
        {
            yield return _delay;
            
            _currentAmountChars++;
            _text.text += _additionChar;
        }

        yield return _delay;

        _currentAmountChars = 0;
        StartCoroutine(Loading());
    }
}
