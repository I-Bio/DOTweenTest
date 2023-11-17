using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _target;
    [SerializeField] private float _duration;
    
    private MeshRenderer _meshRenderer;
    
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _meshRenderer.material.DOColor(_target, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
