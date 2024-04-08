using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale = Vector3.one;
    [SerializeField] private float _duration = 1.0f;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
