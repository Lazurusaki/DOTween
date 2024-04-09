using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _replaceText;
    [SerializeField] private string _addText;
    [SerializeField] private string _bruteForceText;
    [SerializeField] private float _duration = 1.0f;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_replaceText, _duration));
        sequence.Append(_text.DOText(_addText, _duration).SetRelative());
        sequence.Append(_text.DOText(_bruteForceText, _duration, true, ScrambleMode.All));    
    }
}
