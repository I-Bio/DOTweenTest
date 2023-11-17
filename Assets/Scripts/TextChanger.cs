using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _toChange;
    [SerializeField] private string _toAdd;
    [SerializeField] private string _toBrute;
    [SerializeField] private float _duration;

    private Text _text;
    
    private void Start()
    {
        _text = GetComponent<Text>();
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_toChange, _duration));
        sequence.Append(_text.DOText(_toAdd, _duration).SetRelative());
        sequence.Append(_text.DOText(_toBrute, _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
