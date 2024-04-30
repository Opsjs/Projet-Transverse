using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeHolder : MonoBehaviour
{
    [SerializeField] GameObject icon;
    private enum Enigmes
    {
        Enigme1,
        Enigme2,
        Enigme3,
        Enigme4,
    }
    [SerializeField] private Enigmes enigme;

    private void FixedUpdate()
    {
        switch (enigme)
        {
            case Enigmes.Enigme1:
                if (Enigme1.isCorrect)
                {
                    GameObject.Destroy(icon);
                    Debug.Log($"�nigme 1 r�solue");
                }
                break;
            case Enigmes.Enigme2:
                if (Enigme2.isCorrect)
                {
                    GameObject.Destroy(icon);
                    Debug.Log($"�nigme 2 r�solue");
                }
                break;
            case Enigmes.Enigme3:
                if (Enigme3.isCorrect)
                {
                    GameObject.Destroy(icon);
                    Debug.Log($"�nigme 3 r�solue");
                }
                break;
            case Enigmes.Enigme4:
                if (Enigme4.isCorrect)
                {
                    GameObject.Destroy(icon);
                    Debug.Log($"�nigme 4 r�solue");
                }
                break;
        }
    }
}
