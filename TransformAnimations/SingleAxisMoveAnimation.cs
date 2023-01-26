using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Animations;

[Serializable]
public class SingleAxisMoveAnimation //: BaseTweenAnimation
{
    [SerializeField] private Axis _axis;
    [SerializeField] private float _endValue;
    [SerializeField] private float _startValue;
    [SerializeReference] private IMoveTransformTween _moveTween;

    // public override void SetStartValues() => _rectTransform.anchoredPosition =
    //     _axis.AxisVector(_rectTransform.anchoredPosition, _startValue);
    //
    // public override void SetEndValues() =>
    //     _rectTransform.anchoredPosition = _axis.AxisVector(_rectTransform.anchoredPosition, _endValue);
    //
    // public override Tween GetTween()
    // {
    //     var tween = _axis switch
    //     {
    //         Axis.X => XLocalMove(),
    //         Axis.Y => YLocalMove(),
    //         Axis.Z => ZLocalMove(),
    //         _ => XLocalMove()
    //     };
    //
    //     return tween;
    // }
    //
    // private Tween XLocalMove() => _rectTransform.DOAnchorPosX(_endValue, _duration);
    // private Tween YLocalMove() => _rectTransform.DOAnchorPosY(_endValue, _duration);
    // private Tween ZLocalMove() => _rectTransform.DOAnchorPos3DZ(_endValue, _duration);
}