using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class MoveTransformTween : IMoveTransformTween, IPunchTransformTween, IScaleTween
{
    [SerializeField] private Transform _transform;

    public Tween GetMoveTween(Vector3 endValue, float duration) => _transform.DOMove(endValue, duration);

    public Tween GetLocalMoveTween(Vector3 endValue, float duration)
    {
        throw new NotImplementedException();
    }

    public Tween GetPunchScaleTween(Vector3 value, float duration, int vibrato, float elasticity) =>
        _transform.DOPunchScale(value, duration, vibrato, elasticity);

    public Tween GetPunchRotationTween(Quaternion value, float duration, int vibrato, float elasticity) =>
        _transform.DOPunchRotation(value.eulerAngles, duration, vibrato, elasticity);

    public void SetPosition(Vector3 value) => _transform.position = value;
    public void SetLocalPosition(Vector3 value) => _transform.localPosition = value;

    public Tween GetScaleTween(Vector3 endValue, float duration) => _transform.DOScale(endValue, duration);

    public void SetScaleValue(Vector3 value) => _transform.localScale = value;
}