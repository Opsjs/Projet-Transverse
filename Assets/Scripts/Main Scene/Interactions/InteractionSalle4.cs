using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSalle4 : MonoBehaviour
{
    private Transform transform;
    [SerializeField] Camera cam;
    Vector3 cameraPosition;
    Vector3 objectTransform;

    private void Start()
    {
        transform= GetComponent<Transform>();
        objectTransform = transform.position;
    }
    public void OnMouseDown()
    {
        Vector3 cameraPosition = cam.transform.position;
        cam.orthographicSize = 2.0f;
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-1);
    }
    private void OnMouseUp()
    {
        cam.orthographicSize = 5.0f;
        cam.transform.position = new Vector3(60, 0, -10);
    }
}
