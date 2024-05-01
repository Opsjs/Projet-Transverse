using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleManager : MonoBehaviour
{
    public Text content;

    public Animator animator;

    private string sentence;

    public static CollectibleManager instance;

    [Header("Collectibles")]
    [SerializeField] GameObject trophy;
    [SerializeField] GameObject medal;
    [SerializeField] GameObject postalCard;
    [SerializeField] GameObject hoodie;
    [SerializeField] GameObject luge;



    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance dans la scène");
        }
        instance = this;
    }

    private void Start()
    {
        if (Collectibles.IsCollectedTrophy)
        {
            trophy.SetActive(false);
        }
        if (Collectibles.IsCollectedLuge)
        {
            luge.SetActive(false);
        }
        if (Collectibles.IsCollectedMedal)
        {
            medal.SetActive(false);
        }
        if (Collectibles.IsCollectedHoodie)
        {
            hoodie.SetActive(false);
        }
        if (Collectibles.IsCollectedPostalCard)
        {
            postalCard.SetActive(false);
        }
    }
    public void StartPopUp(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        content.text = dialogue.sentences[0];
    }
    public void EndPopUp()
    {

        animator.SetBool("IsOpen", false);
    }
    
}
