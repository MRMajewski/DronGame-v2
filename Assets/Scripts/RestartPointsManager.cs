using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPointsManager : MonoBehaviour {

    public DronController dronController; // referencja do skryptu DronController, tu w 
    internal int numberOfBoxes;

    //Inspektorze dodajemy Drona

    // Use this for initialization
    void Start () {
		
	}

    public void UpdateStartPoint(Transform newTransform) //metoda podmieniająca kolejne checkpointy
    {
        dronController.startPoint = newTransform;
    }
}
