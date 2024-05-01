using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enigmeLoader : MonoBehaviour
{
    private Cameracontrol cameracontrol;
    public enum Enigmes {
        Enigme1,
        Enigme2, 
        Enigme3,
        Enigme4
    }
    [SerializeField] string EnigmeName;
    private void Start()
    {
         cameracontrol = FindObjectOfType<Cameracontrol>();
    }
    private void OnMouseDown()
    {
        switch (EnigmeName)
        {
            case "MainScene":
                SceneManager.LoadScene("MainScene");
                //Camera.main.transform.position = cameracontrol.position;
                break;
            case "Enigme1":
                cameracontrol.position = Camera.main.transform.position;
                SceneManager.LoadScene("Enigme1");
                break;
            case "Enigme2":
                cameracontrol.position = Camera.main.transform.position;
                SceneManager.LoadScene("Enigme2");
                break;
            case "Enigme3":
                cameracontrol.position = Camera.main.transform.position;
                SceneManager.LoadScene("Enigme3");
                break;
            case "Enigme4":
                cameracontrol.position = Camera.main.transform.position;
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
