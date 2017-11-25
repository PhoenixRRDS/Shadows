using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    Transform target;

    [SerializeField]
    float xOff, yOff, zOff;

    [SerializeField]
    float speed;

    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(new Vector3(target.position.x + xOff, target.position.y + yOff, target.position.z + zOff));
        rb.velocity = transform.forward * speed;
	}
}
