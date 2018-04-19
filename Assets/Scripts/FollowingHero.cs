using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingHero : MonoBehaviour {

    public GameObject hero;
    public float smooth;

    private Vector3 currVelocity;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Vector3 newCameraPosition =
        //  new Vector3(hero.transform.position.x, hero.transform.position.y,
        // transform.position.z); // zbieramy nową pozycję z pozycji Drona
        Vector3 newCameraPosition =
       new Vector3(hero.transform.position.x, transform.position.y,
         transform.position.z);

        transform.position =
            Vector3.SmoothDamp(transform.position, newCameraPosition,
            ref currVelocity, smooth); // motoda dodaje plynności kamerce

	}
}
