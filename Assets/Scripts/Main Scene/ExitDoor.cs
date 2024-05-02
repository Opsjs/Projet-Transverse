using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] SendScore sendScore;
    private void OnMouseDown()
    {
        if (Enigme1.isCorrect && Enigme2.isCorrect && Enigme3.isCorrect && Enigme4.isCorrect)
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
