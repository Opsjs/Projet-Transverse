using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Enigme3
{
    public static bool isCorrect;
}
public class yearCheck : MonoBehaviour
{
    public InputField champDeTexte;
    public Text answer;

    private void Start()
    {
        Enigme3.isCorrect = false;
        if (champDeTexte == null)
        {
            Debug.LogError("Champ de texte non référencé !");
            return;
        }
        champDeTexte.onEndEdit.AddListener(SoumettreTexte);
    }

    private void SoumettreTexte(string texteSaisi)
    {
        Debug.Log(texteSaisi);
        if (texteSaisi == "2021")
        {
            answer.color = Color.green;
            Enigme3.isCorrect = true;
            Debug.Log(Enigme3.isCorrect);
        }
        else
        {
            answer.color = Color.red;
            Enigme3.isCorrect=false;
            Debug.Log(Enigme3.isCorrect);
        }
    }
}
