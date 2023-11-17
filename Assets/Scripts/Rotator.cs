using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _angle;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        transform.DORotate(_angle, _duration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
    }
}
