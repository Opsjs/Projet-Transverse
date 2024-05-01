using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cameracontrol : MonoBehaviour
{
     public Vector3 position;

    public enum Salles
    {
        Salle1,
        Salle2, 
        Salle3,
        Salle4
    }
    public static Salles salle = Salles.Salle1;
    private void Start()
    {
        position = transform.position;

        switch (salle)
        {
            case Salles.Salle1:
                transform.position = new Vector3(0, 0, 0);
                break;
            case Salles.Salle2:
                transform.position = new Vector3(20, 0, 0);
                break;
            case Salles.Salle3:
                transform.position = new Vector3(40, 0, 0);
                break;
            case Salles.Salle4:
                transform.position = new Vector3(60, 0, 0);
                break;
        }
    }
    public void CameraMovementLeft()
    {

        float posX = -20;
        //rb2d.velocity = new Vector2(Mathf.Clamp(posX, transform.position.x, transform.position.x + 20), 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + posX, 0, 60), 0, 0);
        position = new Vector3(Mathf.Clamp(position.x - 20, 0, 60), 0, 0);
        previousRoom();
        Debug.Log(salle);
    }
    public void CameraMovementRight()
    {
        float posX = 20;
        //rb2d.velocity = new Vector2(posX, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + posX, 0, 60), 0, 0);
        position = new Vector3(Mathf.Clamp(position.x + 20, 0, 60), 0, 0);
        nextRoom();
        Debug.Log(salle);
    }
    public void nextRoom()
    {
        int nombreDeSalles = Enum.GetNames(typeof(Salles)).Length;
        int prochaineSalle = ((int)salle + 1) % nombreDeSalles;
        salle = (Salles)prochaineSalle;
    }
    public void previousRoom()
    {
        int nombreDeSalles = Enum.GetNames(typeof(Salles)).Length;
        int prochaineSalle = ((int)salle - 1 + nombreDeSalles) % nombreDeSalles;
        salle = (Salles)prochaineSalle;
    }
}

public class CameraManager
{
    public Vector3 CameraPosition;

    public void SaveCameraPosition()
    {
        CameraPosition= Camera.main.transform.position;
    }
    public void RestoreCameraPosition()
    {
        Camera.main.transform.position= CameraPosition;
    }
}