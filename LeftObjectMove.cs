using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftObjectMove : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 5.0f;

    void Start() {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update() {
        if (playerControllerScript.gameOver == false) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
