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

    private bool InPopUp;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance dans la scène");
        }
        instance = this;
    }
    public void StartPopUp(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        InPopUp= true;
        content.text = dialogue.sentences[0];
    }
    public void EndPopUp()
    {
        InPopUp= false;
        animator.SetBool("IsOpen", false);
    }
}
