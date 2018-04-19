using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour {


    int numberOfBoxes;
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
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
