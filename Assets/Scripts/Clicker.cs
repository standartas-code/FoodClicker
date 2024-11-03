using DG.Tweening;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [Header("Animation settings")]
    public float scale = 1.2f;
    public float duration = 0.1f;
    public Ease ease;

    [Header("Sound")]
    public AudioClip clickSound;

    [HideInInspector]public int clicks = 0;

    private AudioSource audioSource;
   
    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown() 
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);
        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(clickSound);

        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);//ease - how the animation will be played
            //.SetLoops(2, LoopType.Yoyo);
    }
}
