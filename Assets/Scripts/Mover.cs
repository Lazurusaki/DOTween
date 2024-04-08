using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _offset = Vector3.zero;
    [SerializeField] private float _duration = 2.0f;
    private void Start()
    {
        transform.DOMove(transform.position + _offset, _duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
