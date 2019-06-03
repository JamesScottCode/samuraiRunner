using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayerModel : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 10.0f;
    private float speedIncrement = .005f; // previously .001
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private bool isAlive = true;
    private float animationDuration = 2.0f;
    public GameObject deathScree;
    public GameObject hudText;
    public Text speedText;
    public Text coinText;
    public Text scoreText;
    public string coinString;
    public string speedString;
    public string scoreString;
    public float speedTrun;
    public int speedInt;
    public int coinCollected;
    public int score;
    public AudioSource coinSound;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == true)
        {
            //speed up test top
            speed += speedIncrement;
            speedTrun = Mathf.Round(speed * 10) /10;
            speedString = speedTrun.ToString();
            speedText.text = speedString;

            //coin update
            coinString = coinCollected.ToString();
            coinText.text = coinString;

            if (Time.time < animationDuration)
            {
                controller.Move(Vector3.forward * speed * Time.deltaTime);
                return;
            }

            moveVector = Vector3.zero;

            if (controller.isGrounded)
            {
                verticalVelocity = -0.5f;
            }
            else { verticalVelocity -= gravity * Time.deltaTime; }

            //x left and right
            moveVector.x = Input.GetAxisRaw("Horizontal") * (speed); //speed * 2


            //y up and down
            moveVector.y = verticalVelocity;

            //z forward and backward
            moveVector.z = speed;
            controller.Move(moveVector * Time.deltaTime);
            
            //hide death sceen
         }
        else
        {
            //space for future update
        }
    }

    //collision

    void OnTriggerEnter(Collider other)

    {
        if(other.tag == "coin")
        {
            coinCollected += 1;
            //Debug.Log("coins");
            Destroy(other.gameObject);
            coinSound.Play();
        }
        else if (other.tag == "floor" || other.tag == "Player")
        {
            //space for future update
        }
        else //on death
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        isAlive = false;
        speed = 0;
        //dead stuff here
        speedInt = (int)speedTrun;
        score =  speedInt * coinCollected;
        scoreString = score.ToString();
        scoreText.text = scoreString;
        deathScree.SetActive(true);
        hudText.SetActive(false);
        GetComponent<Animation>().Stop();
    }
}
