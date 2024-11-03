using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [Header("Baker")]
    public ShopButton bakerButton;
    public float bakerPrice = 10;
    public int bakerCount = 0;

    private Clicker clicker;

    private void Start() 
    {
        clicker = FindObjectOfType<Clicker>();
    }

    public void BuyBaker()
    {
        var realPrice = (int)Mathf.Ceil(bakerPrice);
        if (clicker.clicks >= realPrice)
        {
            clicker.clicks -= realPrice;
            UiManager.instance.UpdateClicks(clicker.clicks);

            bakerPrice *= 1.15f; // 15% increase
            realPrice = (int)Mathf.Ceil(bakerPrice);
            bakerButton.UpdateText(realPrice, ++bakerCount);
        }
    }
}
