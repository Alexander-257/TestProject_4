using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public GameObject player;
    private bool cooldown = false;
    private int jumpScore = 0;

    void Start() { }

    void Update() {
        if(transform.position.z < 1) {
            if (player.transform.position.y > 0.51f && !cooldown) {
                jumpScore++;
                Debug.Log(jumpScore);
                cooldown = true;
                Invoke("CoolDown", 1.5f);
            }
        }
    }

    private void CoolDown() {
        cooldown = false;
    }
}
