using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCrate : MonoBehaviour {

    CounterController counterController; //referencja do klasy CounterController
    public AudioClip clip;


	// Use this for initialization
	void Start () {
        counterController = GameObject.Find("Manager").GetComponent<CounterController>(); //a tu w niej szukamy Managera
        if(counterController==null)
        {
            Debug.LogError("Nie ma CounterControllera");
        }
    }

    void OnTriggerEnter2D(Collider2D other) //funkcja zwróci nam jaki obiekt skolidował z obiektem, który będzie miał przypięty ten skrypt
    {
        if (other.gameObject.name == "Dron") // jeśli koliduje z dronem to...
        {
          Destroy(this.gameObject); //zmień jego pozycje na startPoint
            
            counterController.IncrementCounter();
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
