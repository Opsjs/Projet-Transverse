using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Enigme4
{
    public static bool isCorrect;
}
public class brakeSelection : MonoBehaviour
{
    [SerializeField] GameObject selectionIndicator;
    private void Start()
    {
        
    }
    private void OnMouseDown()
    {
        selectionIndicator.SetActive(!selectionIndicator.activeSelf);
        if (selectionIndicator.activeSelf && gameObject.tag=="CorrectBrake") 
        {
            Enigme4.isCorrect= true;
        } else
        {
            Enigme4.isCorrect = false;
        }
        Debug.Log(Enigme4.isCorrect);
    }
}
