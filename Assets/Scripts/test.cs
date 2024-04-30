using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Enigme 1 : {Enigme1.isCorrect}");
        Debug.Log($"Enigme 2 : {Enigme2.isCorrect}");
        Debug.Log($"Enigme 3 : {Enigme3.isCorrect}");
        Debug.Log($"Enigme 4 : {Enigme4.isCorrect}");
    }
}
