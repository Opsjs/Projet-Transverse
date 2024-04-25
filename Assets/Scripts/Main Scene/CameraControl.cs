using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour
{
    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
    }
    public void CameraMovementLeft()
    {

        float posX = -20;
        //rb2d.velocity = new Vector2(Mathf.Clamp(posX, transform.position.x, transform.position.x + 20), 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + posX, 0, 60), 0, 0);
    }
    public void CameraMovementRight()
    {
        float posX = 20;
        //rb2d.velocity = new Vector2(posX, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + posX, 0, 60), 0, 0);
    }
}
