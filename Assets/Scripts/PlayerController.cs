using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8.0f;

    void Start(){
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update(){
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        float zSpeed = Input.GetAxis("Vertical") * speed;  

        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
       
        /*
        if (Input.GetKey(KeyCode.UpArrow)==true) {
            playerRigidbody.AddForce(0f,0f,speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true) {
            playerRigidbody.AddForce(0f, 0f, -speed );
        }
        if (Input.GetKey(KeyCode.RightArrow) == true) {
            playerRigidbody.AddForce(speed , 0f,0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            playerRigidbody.AddForce(-speed , 0f, 0f);
        }
       */
    }

    public void Die() {
        gameObject.SetActive(false);

       GameManager gameManager= FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
}
