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

    [Header("Sound")]
    public AudioClip clickSound;

    [Header("Particles")]
    public ParticleSystem clickParticles;


    private AudioSource audioSource;
    [HideInInspector] public int clicks = 0;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }


    private void OnMouseDown() 
    {
        clickParticles.Emit(1);

        clicks++;
        UiManager.instance.UpdateClicks(clicks);

        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(clickSound);

        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);
    }
}
