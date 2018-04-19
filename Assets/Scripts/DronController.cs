using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronController : MonoBehaviour {

    public float dronSpeed; // public pozwala nam zmieniać z Inspektora wartość danej zmiennej
    public float jumpForce;
    public Transform groundTester;
    public LayerMask LayersToTest;
    public Transform startPoint;
    public AudioClip clip;

    Animator anim;
    Rigidbody2D rgBody;

    private bool onTheGround; // tzn flaga, która dalej stanie się warunkiem
    private float radius = 0.1f; //długość okręgu z metody OverlapCircle do kolizji z gruntem

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>(); //pobieramy Animatora danego obiektu tzn drona
        rgBody = GetComponent<Rigidbody2D>(); //pobieramy komponent RigidBody obiektu do którego przyklejony jest skrypt
		
	}


	
	// Update is called once per frame
	void Update () {

        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Fail"))// warunek sprawdza , jeśli włączy się animacja 'Fail', to kończy metode
        {
            rgBody.velocity = Vector2.zero; //zerujemy prędkość Drona
            return;
        }

        onTheGround = Physics2D.OverlapCircle (groundTester.position, radius, LayersToTest);
            //metoda sprawdza czy w danym okręgu od obiektu, nie zachodzą z nim kolizje.



        float horizontalMove = Input.GetAxis("Horizontal"); //pobieramy do zmiennej o położeniu obiektu w poziomie
        rgBody.velocity = new Vector2(horizontalMove*dronSpeed, rgBody.velocity.y);
        //dodajemy nowy wektor, zmieniający prędkość obiektu

        if(Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            rgBody.AddForce(new Vector2(0f, jumpForce)); // dodajemy nową siłę, która wywala drona do góry
            anim.SetTrigger("jump");// zapodajemy nową animację
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }



        anim.SetFloat("speed", horizontalMove);
		
	}

    public void RestartDron()
    {
        gameObject.transform.position = startPoint.position;
    }
}
