using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        transform.DOMove(_point.position, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
