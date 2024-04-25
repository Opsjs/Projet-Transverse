using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureMovement : MonoBehaviour
{

    [SerializeField] float RaycastDistance = 1f;

    [SerializeField] SpriteRenderer SpriteRenderer;


    
    [SerializeField] Vector2 TargetPosition ;
    
    

    void Awake()
    {
        SpriteRenderer= GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        CheckCorrectPosition();
    }



    public bool CheckCorrectPosition()
    {
        if (transform.position.x == TargetPosition.x && transform.position.y == TargetPosition.y)
        {
            SpriteRenderer.color = Color.green;
            return true;
        }
        SpriteRenderer.color = Color.white;
        return false;
    }

    void OnMouseDown()
    {
        RaycastHit2D up = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y + 1.35f, transform.position.z), Vector2.up, RaycastDistance);
        RaycastHit2D down = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - 1.35f, transform.position.z), -Vector2.up, RaycastDistance);
        RaycastHit2D left = Physics2D.Raycast(new Vector3(transform.position.x - 1.35f, transform.position.y, transform.position.z), -Vector2.right, RaycastDistance);
        RaycastHit2D right = Physics2D.Raycast(new Vector3(transform.position.x + 1.35f, transform.position.y, transform.position.z), Vector2.right, RaycastDistance);
        //Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 1.35f, transform.position.z), Vector2.up, color:Color.red, 20);
        if (up.collider == null)
        {
            transform.Translate(new Vector3(0, 2.5f));
        }
        else if (down.collider == null)
        {
            transform.Translate(new Vector3(0, -2.5f));
        }
        else if (left.collider == null)
        {
            transform.Translate(new Vector3(-2.5f, 0));
        }
        else if (right.collider == null)
        {
            transform.Translate(new Vector3(2.5f, 0));
        }

    }
}
