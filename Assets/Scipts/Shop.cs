using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public ParticleSystem clickParticles;

    [Header("Granny")]
    public ShopButton grannyButton;
    public float grannyPrice = 10;
    public int grannyCount = 0;
    public int cpg = 1; //cookies per granny
    public float cookTime = 1;


    private Clikcer clikcer;

    void Start()
    {
        //search in whole scene for object with type Clikcer
        clikcer = FindAnyObjectByType<Clikcer>();

        InvokeRepeating("Cook", 0, cookTime);
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

    void Cook()
    {
        var particles = Mathf.Min(grannyCount * cpg, 100);
        clickParticles.Emit(particles);
        clikcer.clicks += grannyCount * cpg;
        UiManager.instance.UpdateClicks(clikcer.clicks);
    }
}
