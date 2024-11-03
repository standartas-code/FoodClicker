using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [Header("Granny")]
    public ShopButton grannyButton;
    public float grannyPrice = 10;
    public int grannyCount = 0;


    private Clikcer clikcer;

    void Start()
    {
        //search in whole scene for object with type Clikcer
        clikcer = FindAnyObjectByType<Clikcer>();
    }

    public void BuyGranny()
    {
        if (clikcer.clicks >= grannyPrice)
        {
            clikcer.clicks -= (int)Mathf.Ceil(grannyPrice);
            UiManager.instance.UpdateClicks(clikcer.clicks);

            grannyCount++;
            grannyPrice = grannyPrice * 1.1f;//increase price by 10%   
            grannyButton.UpdateText((int)Mathf.Ceil(grannyPrice), grannyCount);
        }
    }
}
