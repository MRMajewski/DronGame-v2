using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour {

    public Transform cameraTransform; // tu w Inspektorze wstawimy naszą kamere (chyba)
    public float parallaxFactor; //współczynnik paralaksy

    private Vector3 previousCameraPosition; //poprzednia pozycja kamery
    private Vector3 deltaCameraPosition; //przesunięcie kamery

	// Use this for initialization
	void Start () {

        previousCameraPosition = cameraTransform.position; //do zmiennej pobieramy obecną pozycje kamery


    }
	
	// Update is called once per frame
	void Update () {

        deltaCameraPosition = cameraTransform.position - previousCameraPosition;

        Vector3 parallaxPosition =
            new Vector3(transform.position.x + (deltaCameraPosition.x * parallaxFactor), transform.position.y, transform.position.z);

        transform.position = parallaxPosition; //wszystko co przeliczyliśmy zapisujemy jako nową pozycje obiektu
        previousCameraPosition = cameraTransform.position; // tu pozycja z poprzedniej klatki, będzie służyła do nowym pomiarów Parallaksy



    }
}
