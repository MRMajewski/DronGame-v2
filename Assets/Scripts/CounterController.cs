using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour {


    public int numberOfBoxes;
    public Text counterView;

	// Use this for initialization
	void Start () {

        ResetCounter();

    }

    public void IncrementCounter()
    {
        numberOfBoxes++;
        counterView.text = numberOfBoxes.ToString();
    }

    public void ResetCounter()
    {

       // numberOfBoxes = Convert.ToInt16(FindObjectOfType<PickUpCrate>());
 
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
