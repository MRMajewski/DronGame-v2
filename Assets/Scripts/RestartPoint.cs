using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPoint : MonoBehaviour {

    RestartPointsManager restartPointsManager;
    //SpriteRenderer sprRenderer;
    public Sprite spriteImage; // deklaruje nowy sprite który podmienimy jak dotkniemy skrzynki
    public AudioClip clip;

    // Use this for initialization
    void Start () {
        restartPointsManager = GameObject.Find("Manager").GetComponent<RestartPointsManager>();//na wstępie znajdź i pobierz ten komponent z Managera
        if(restartPointsManager==null)
        {
            Debug.LogError("RestartPointsManager nie został znaleziony.");
        }
       
    }
	
    void OnTriggerEnter2D (Collider2D other)
    {
       if( other.gameObject.tag == "Player")      //używamy tagu. Taga można użyć kiedy w grze jest więcej graczy o;
        {
            restartPointsManager.UpdateStartPoint(this.gameObject.transform);
            //jeśli tak to wywołujemy UpdateStartPoint dla tego obiektu dla ktorego piszemy skrypt
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteImage; // podmieniam sprite dla tego obiektu
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }

    }
}
