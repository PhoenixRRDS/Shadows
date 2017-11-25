using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    Transform target;

    [SerializeField]
    float xOff, yOff, zOff;

    [SerializeField]
    float speed, maxHealth = 100;

    [SerializeField]
    GameObject deathEffect;

    Rigidbody rb;

    float health;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(new Vector3(target.position.x + xOff, target.position.y + yOff, target.position.z + zOff));
        rb.velocity = transform.forward * speed;
	}

    public void TakeDamage(int amt)
    {
        health -= amt;
        if (health <= 0) {
            Die();
        }
    }

    void Die()
    {
        GameObject _deathEffect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        _deathEffect.AddComponent<SelfDestruct>();
        Destroy(gameObject);
    }
}
