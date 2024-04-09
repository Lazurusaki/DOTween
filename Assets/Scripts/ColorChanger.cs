using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration = 1.0f;

    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo); 
    }
 
}
