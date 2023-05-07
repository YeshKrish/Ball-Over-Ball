using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CircleRotate : MonoBehaviour
{

    private void Start()
    {
        DG.Tweening.DOTween.SetTweensCapacity(tweenersCapacity: 800000, sequencesCapacity: 200000);
    }

    // Update is called once per frame
    void Update()
    {
        transform.DORotate(new Vector3(0f, 0f, 360f), 10f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear).SetRelative();
        //LeanTween.rotateAround(gameObject, Vector3.forward, 360f, 5f).setRepeat(-1);
    }
}
