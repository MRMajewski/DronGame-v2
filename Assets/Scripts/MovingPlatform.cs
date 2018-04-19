using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Transform navStartPoint;
    public Transform navEndPoint;
    public float speed;


    private Vector2 startPoint;
    private Vector2 endPoint;

    private Vector2 currentPlatformPosition;

    // Use this for initialization
    void Start() {
        startPoint = navStartPoint.position;
        endPoint = navEndPoint.position;
        Destroy(navStartPoint.gameObject);
        Destroy(navEndPoint.gameObject);

    }

    // Update is called once per frame
    void Update() {

        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;
        // transform.Translate(speed, 0, 0); //przesunięcie platformy tylko w osi x

    }

    void OnTriggerEnter2D(Collider2D other) // ta sprawdza czy nastąpił kontakt kolajderów
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = transform; // przypinamy Drona do platformy, tzn jakby do niej należał
            other.attachedRigidbody.Sleep();
        }

        // Debug.Log(other.gameObject.name);


    }

    void OnTriggerExit2D(Collider2D other) // ta sprawdza czy nastąpił kontakt kolajderów
    {
        Debug.Log(other.gameObject.name + " - OUT");
        if (other.gameObject.tag == "Player") { 
        other.transform.parent = null; //wyrzucamy tu drona z platformy, tzn jest osobynm obiektem
    }
    }



    //ten sposob nie działa
    //  void OnTriggerStay2D(Collider2D other) //ta metoda sprawdza czy kontakt ciągle trwa
    //{
    //     other.attachedRigidbody.velocity += new Vector2(speed, 0);
    //do prędkości podczepionego elementu dodajemy prędkość Drona
    //  }
}
