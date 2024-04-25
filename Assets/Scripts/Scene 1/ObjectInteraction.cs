using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Camera camera;
    Vector3 cameraPosition;
    //Vector3 LastPos;
    private void FixedUpdate()
    {
        Vector3 LastPos = transform.position;
    }

    public void OnMouseDown()
    {
        Vector3 cameraPosition = camera.transform.position;
        camera.orthographicSize = 1.0f;
        camera.transform.position = transform.position;
        transform.position = cameraPosition;
    } 
private void OnMouseUp()
    {
        camera.orthographicSize = 5.0f;
        camera.transform.position = cameraPosition;
        //transform.position = LastPos;
    }
    public void Interaction()
    {
        camera.orthographicSize = 1.0f;
        camera.transform.position = transform.position;
        
    }
}
