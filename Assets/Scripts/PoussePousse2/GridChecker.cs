using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Enigme1
{
    public static bool isCorrect;
}
public class GridChecker : MonoBehaviour
{
    public List<GameObject> Cubes;
    [SerializeField] SpriteRenderer SpriteRenderer;

    public bool AreAllElementsCorrectlyPlaced()
    {
        foreach (GameObject piece in Cubes)
        {
            bool isCorrectPosition = piece.GetComponent<PictureMovement>().CheckCorrectPosition();

            if (!isCorrectPosition)
            {
                return false;
            }
        }

        return true;
    }
    private void FixedUpdate()
    {
        Enigme1.isCorrect = AreAllElementsCorrectlyPlaced();
        Debug.Log(Enigme1.isCorrect);
    }
    /*    public bool CheckCorrectPosition()
        {
            Debug.Log(transform.position);
            Debug.Log(TargetPosition);
            if (transform.position.x == TargetPosition.x && transform.position.y == TargetPosition.y)
            {
                SpriteRenderer.color = Color.green;
                return true;
            }
            return false;
        }*/
}
