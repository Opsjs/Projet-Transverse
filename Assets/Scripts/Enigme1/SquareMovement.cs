using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{

    float RaycastDistance = 1.5f;

    [SerializeField] int id;
    //public float[] positions;
    [SerializeField] Vector2 TargetPosition;
    
    void Awake()
    {
        /*switch (id)
        {
            case 1:
                {
                    Vector2 TargetPosition = new Vector2(-3, 3);
                    Debug.Log(TargetPosition);
                    break;
                }
            case 2:
                {
                    Vector2 TargetPosition = new Vector2(-1, 3);
                    Debug.Log(TargetPosition);
                    break;
                }
            case 3:
                {
                    Vector2 TargetPosition = new Vector2(1, 3);
                    Debug.Log(TargetPosition);
                    break;
                }
            case 4:
                {
                    Vector2 TargetPosition = new Vector2(3, 3);
                    Debug.Log(TargetPosition);
                    break;
                }
            case 5:
                {
                    Vector2 TargetPosition = new Vector2(-3, 1);
                    Debug.Log(TargetPosition);
                    break;
                }
            case 6:
                {
                    Vector2 TargetPosition = new Vector2(-1, 1);
                    break;
                }
            case 7:
                {
                    Vector2 TargetPosition = new Vector2(1, 1);
                    break;
                }
            case 8:
                {
                    Vector2 TargetPosition = new Vector2(3, 1);
                    break;
                }
            case 9:
                {
                    Vector2 TargetPosition = new Vector2(-3, -1);
                    break;
                }
            case 10:
                {
                    Vector2 TargetPosition = new Vector2(-1, -1);
                    break;
                }
            case 11:
                {
                    Vector2 TargetPosition = new Vector2(1, -1);
                    break;
                }
            case 12:
                {
                    Vector2 TargetPosition = new Vector2(3, -1);
                    break;
                }
            case 13:
                {
                    Vector2 TargetPosition = new Vector2(-3, -3);
                    break;
                }
            case 14:
                {
                    Vector2 TargetPosition = new Vector2(-1, -3);
                    break;
                }
            case 15:
                {
                    Vector2 TargetPosition = new Vector2(1, -3);
                    break;
                }
        }*/

        Debug.Log(TargetPosition);
    }

    void FixedUpdate()
    {
    }





    void OnMouseDown()
    {
        Debug.Log(TargetPosition);
        RaycastHit2D up = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 0.6f, transform.position.z), Vector2.up, RaycastDistance);
        RaycastHit2D down = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y -0.6f, transform.position.z), -Vector2.up, RaycastDistance);
        RaycastHit2D left = Physics2D.Raycast(new Vector3(transform.position.x - 0.6f, transform.position.y, transform.position.z), -Vector2.right, RaycastDistance);
        RaycastHit2D right = Physics2D.Raycast(new Vector3(transform.position.x + 0.6f, transform.position.y, transform.position.z), Vector2.right, RaycastDistance);
        if (up.collider == null)
        {
            transform.Translate(new Vector3(0, 2));
        } else if (down.collider == null)
        {
            transform.Translate(new Vector3(0, -2));
        } else if (left.collider == null)
        {
            transform.Translate(new Vector3(-2, 0));
        } else if (right.collider == null)
        {
            transform.Translate(new Vector3(2, 0));
        }

    }
}
