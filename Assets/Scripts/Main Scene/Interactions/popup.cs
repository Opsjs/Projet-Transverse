using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    [SerializeField] private GameObject GlobalImage;

    private void OnMouseDown()
    {
        GlobalImage.SetActive(true);
    }
    private void OnMouseUp()
    {
        GlobalImage.SetActive(false);
    }
}
