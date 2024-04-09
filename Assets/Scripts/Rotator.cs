using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration = 1;

    private Vector3 _angle = new Vector3(0.0f,360.0f,0.0f);
    
    private void Start()
    {
        transform.DORotate(_angle,_duration, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1,LoopType.Restart);
    }
}
