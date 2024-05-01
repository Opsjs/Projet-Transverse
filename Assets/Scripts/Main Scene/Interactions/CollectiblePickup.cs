using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Collectibles
{
    public static bool IsCollectedTrophy = false;
    public static bool IsCollectedMedal = false;
    public static bool IsCollectedPostalCard = false;
    public static bool IsCollectedHoodie = false;
    public static bool IsCollectedLuge = false;
}

public class CollectiblePickup : MonoBehaviour
{
    public Dialogue dialogue;
/*    [SerializeField] GameObject trophy;
    [SerializeField] GameObject medal;
    [SerializeField] GameObject postalCard;
    [SerializeField] GameObject hoodie;
    [SerializeField] GameObject luge;*/
    private void Start()
    {
/*        if (!Collectibles.IsCollectedTrophy)
        {
            trophy.SetActive(false);
        }*/
    }
    public void OnMouseDown()
    {
        TriggerPickUp();
        if(Collectibles.IsCollectedHoodie && Collectibles.IsCollectedLuge && Collectibles.IsCollectedMedal && Collectibles.IsCollectedTrophy && Collectibles.IsCollectedPostalCard)
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
                if (!Collectibles.IsCollectedLuge)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsCollectedLuge = true;
                }
                break;
            case "Pull":
                if (!Collectibles.IsCollectedHoodie)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsCollectedHoodie = true;
                }
                break;
            case "PostalCard":
                if (!Collectibles.IsCollectedPostalCard)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsCollectedPostalCard = true;
                }
                break;
            case "LogoJo":
                if (!Collectibles.IsCollectedTrophy)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsCollectedTrophy = true;
                }
                break;
            case "Medal":
                if (!Collectibles.IsCollectedMedal)
                {
                    CollectibleManager.instance.StartPopUp(dialogue);
                    Collectibles.IsCollectedMedal = true;
                }
                break;
        }
            /*CollectibleManager.instance.StartPopUp(dialogue);*/
    }
}
