using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enigmeLoader : MonoBehaviour
{
    public enum Enigmes {
        Enigme1,
        Enigme2, 
        Enigme3,
        Enigme4
    }
    [SerializeField] string EnigmeName;
    private void OnMouseDown()
    {
        switch (EnigmeName)
        {
            case "MainScene":
                SceneManager.LoadScene("MainScene");
                break;
            case "Enigme1":
                SceneManager.LoadScene("Enigme1");
                break;
            case "Enigme2":
                SceneManager.LoadScene("Enigme2");
                break;
            case "Enigme3":
                SceneManager.LoadScene("Enigme3");
                break;
            case "Enigme4":
                SceneManager.LoadScene("Enigme4");
                break;
            default:
                Debug.Log("no scene attributed");
                break;
        }
    }
    public void LoadEnigme(Text name)
    {
        switch (name.text)
        {
            case "Matteo":
                SceneManager.LoadScene("Enigme2");
                break;
            case "Nina":
                SceneManager.LoadScene("Enigme3");
                break;
            case "Nathalie":
                //Condition Énigme fille ok
                SceneManager.LoadScene("Enigme4");
                break;
        }
    }
}
