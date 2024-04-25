using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Enigme2
{
    public static bool isCorrect;
}

public class CodeCheck : MonoBehaviour
{
    public InputField champDeTexte;
    public Text answer;
    private void Start()
    {
        Enigme2.isCorrect = false;
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
        if (texteSaisi == "146712")
        {
            answer.color = Color.green;
            Enigme2.isCorrect= true;
            Debug.Log(Enigme2.isCorrect);
        } else
        {
            answer.color = Color.red;
            Enigme2.isCorrect = false;
            Debug.Log(Enigme2.isCorrect);
        }
    }
}
