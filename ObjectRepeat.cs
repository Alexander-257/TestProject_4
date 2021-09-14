using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRepeat : MonoBehaviour
{
    private Vector3 startPos;
    public float repeatWidth;

    void Start() {
        startPos = transform.position;
    }

    void Update() {
        if (transform.position.z < startPos.z - repeatWidth) {
            transform.position = startPos;
        }
    }
}
