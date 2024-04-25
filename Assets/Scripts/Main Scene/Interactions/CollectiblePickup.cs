using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Collectibles
{
    public static bool IsLugeCollected;
    public static bool IsPullCollected;
    public static bool IsPostalCardCollected;
    public static bool IsLogoJoCollected;
    public static bool IsMedalCollected;
}

public class CollectiblePickup : MonoBehaviour
{
    public Dialogue dialogue;
    private void Start()
    {
        Collectibles.IsLugeCollected = false;
        Collectibles.IsPullCollected = false;
        Collectibles.IsPostalCardCollected = false;
        Collectibles.IsLogoJoCollected = false;
        Collectibles.IsMedalCollected = false;
    }
    public void OnMouseDown()
    {
        TriggerPickUp();
        if(Collectibles.IsPullCollected && Collectibles.IsLugeCollected && Collectibles.IsMedalCollected && Collectibles.IsLogoJoCollected && Collectibles.IsPostalCardCollected)
        {
            Debug.Log("All Collectibles Found !");
        }
        GameObject.Destroy(gameObject);
    }
    void TriggerPickUp()
    {
        switch (tag)
        {
            case "Luge":
                if (!Collectibles.IsLugeCollected)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsLugeCollected = true;
                }
                break;
            case "Pull":
                if (!Collectibles.IsPullCollected)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsPullCollected = true;
                }
                break;
            case "PostalCard":
                if (!Collectibles.IsPostalCardCollected)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsPostalCardCollected = true;
                }
                break;
            case "LogoJo":
                if (!Collectibles.IsLogoJoCollected)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsLogoJoCollected = true;
                }
                break;
            case "Medal":
                if (!Collectibles.IsMedalCollected)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsMedalCollected = true;
                }
                break;
        }
            /*CollectibleManager.instance.StartPopUp(dialogue);*/
    }
}
