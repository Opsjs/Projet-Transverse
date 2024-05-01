using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionHolder : MonoBehaviour
{
    public Transform CameraTransform;

    private void FixedUpdate()
    {
        Debug.Log(CameraTransform.position);
    }
    //private void 
}
