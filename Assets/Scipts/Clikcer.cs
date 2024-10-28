using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Clikcer : MonoBehaviour
{
    [Header("Animation settings")]
    public float scale = 1.2f;
    public float duration = 0.1f;
    public Ease ease;


    private int clicks = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void OnMouseDown() 
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);

        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);
    }
}
