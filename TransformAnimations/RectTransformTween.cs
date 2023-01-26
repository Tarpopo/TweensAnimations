using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class RectMoveTransformTween : IMoveTransformTween, IPunchTransformTween, IScaleTween
{
    [SerializeField] private RectTransform _rectTransform;

    public Tween GetMoveTween(Vector3 endValue, float duration) => _rectTransform.DOAnchorPos(endValue, duration);
    public Tween GetLocalMoveTween(Vector3 endValue, float duration) => _rectTransform.DOLocalMove(endValue, duration);

    public Tween GetPunchScaleTween(Vector3 value, float duration, int vibrato, float elasticity) =>
        _rectTransform.DOPunchAnchorPos(value, duration, vibrato, elasticity);

    public Tween GetPunchRotationTween(Quaternion value, float duration, int vibrato, float elasticity) =>
        _rectTransform.DOPunchRotation(value.eulerAngles, duration, vibrato, elasticity);

    public void SetPosition(Vector3 value) => _rectTransform.anchoredPosition = value;

    public Tween GetScaleTween(Vector3 endValue, float duration) => _rectTransform.DOScale(endValue, duration);

    public void SetScaleValue(Vector3 value) => _rectTransform.localScale = value;
    public void SetLocalPosition(Vector3 value) => _rectTransform.localPosition = value;
}