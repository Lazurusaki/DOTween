using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _text1;
    [SerializeField] private string _text2;
    [SerializeField] private string _text3;
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
        sequence.Append(_text.DOText(_text1, _duration));
        sequence.Append(_text.DOText(_text2, _duration).SetRelative());
        sequence.Append(_text.DOText(_text3, _duration, true, ScrambleMode.All));    
    }
}
