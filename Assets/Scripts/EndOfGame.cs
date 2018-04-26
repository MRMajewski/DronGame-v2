using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfGame : MonoBehaviour {

    public Text text;

    public CounterController counterController;

    public Sprite spriteImageWin;
    public Sprite spriteImageLose;

    public AudioClip Win;
    public AudioClip Lose;

    private AudioManager audioManager;

    void Start()
    {
        text.enabled = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Dron")
        {
            audioManager = FindObjectOfType<AudioManager>();

            counterController = GameObject.Find("Manager").GetComponent<CounterController>();

            int number = counterController.numberOfBoxes;

            if (number >= 7)
            {
                text.enabled = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteImageWin;
                audioManager.ChangeMusic(Win);
            }

            else
            {
                text.text = "YOU LOSE! NOT ENOUGH CRATES! CLICK 'ESCAPE' TO EXIT";
                text.enabled = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteImageLose;
                audioManager.ChangeMusic(Lose);
            }
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && text.enabled==true)
            Application.Quit();
    }


}
