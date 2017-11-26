using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyBullet : MonoBehaviour {

    Rigidbody rb;
    float speed = 25.0f;

    float inceptionTime, timeSinceInception, maxSurvivalTime = 10.0f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        inceptionTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.forward * speed;

        timeSinceInception = Time.time - inceptionTime;
        if (timeSinceInception > maxSurvivalTime)
            Kill();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            print("Bullet has Hit Player");
            Kill();
        }
    }

    void Kill()
    {
        Destroy(gameObject);
    }
}
