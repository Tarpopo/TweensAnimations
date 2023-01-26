using DG.Tweening;
using UnityEngine;

public interface IMoveTransformTween
{
    Tween GetMoveTween(Vector3 endValue, float duration);
    Tween GetLocalMoveTween(Vector3 endValue, float duration);
    public void SetPosition(Vector3 value);
    public void SetLocalPosition(Vector3 value);
}