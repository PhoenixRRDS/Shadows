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

    [SerializeField]
    GameObject enemyBullet, plasmaEffect;

    [SerializeField]
    Transform shootPoint;

    [SerializeField]
    AudioClip explosionClip;

    float timeLeftToShoot, shootInterval = 5.0f;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        health = maxHealth;

        timeLeftToShoot = shootInterval;
        GameObject _plasma = Instantiate(plasmaEffect, transform.position, Quaternion.identity);
        _plasma.AddComponent<SelfDestruct>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(new Vector3(target.position.x + xOff, target.position.y + yOff, target.position.z + zOff));
        rb.velocity = transform.forward * speed; // vary the speed depending on the distance between the player

        if (timeLeftToShoot <= 0.0f)
        {
            timeLeftToShoot = shootInterval;
            Shoot();
        }
        else {
            timeLeftToShoot -= Time.deltaTime;
        }
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
        AudioSource _as = _deathEffect.AddComponent<AudioSource>();
        _as.clip = explosionClip;
        _as.spatialBlend = 1.0f;
        _deathEffect.AddComponent<SelfDestruct>();
        Destroy(gameObject);
    }

    void Shoot()
    {
        Instantiate(enemyBullet, shootPoint.position, transform.rotation);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            coll.gameObject.GetComponent<Player>().TakeDamage(25);
            Die();
        }
    }
}
