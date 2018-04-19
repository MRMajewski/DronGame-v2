using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailController : MonoBehaviour {




	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D (Collider2D other) //funkcja zwróci nam jaki obiekt skolidował z obiektem, który będzie miał przypięty ten skrypt
    {
        if(other.gameObject.name == "Dron") // jeśli koliduje z dronem to...
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail"); //zmień jego pozycje na startPoint
        }
    }
	
}
