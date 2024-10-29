using UnityEngine;
using DG.Tweening;

public class Clicker : MonoBehaviour
{
    public int clicks = 0;

    private void OnMouseDown() 
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);
        transform.DOScale(1.2f, 0.5f).SetLoops(2, LoopType.Yoyo);
    }
}
