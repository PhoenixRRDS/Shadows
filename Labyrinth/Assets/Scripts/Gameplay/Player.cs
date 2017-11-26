using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    const int maxHealth = 100;
    int currentHealth;

    bool isDead;

    [SerializeField]
    GameObject bloodUI, deathUI;

	// Use this for initialization
	void Start () {
        isDead = false;
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(int amt)
    {
        currentHealth -= amt;
        if (currentHealth <= 0)
        {
            Die();
        }
        else {
            bloodUI.GetComponent<Animation>().Play("bloodEffect");
        }
    }

    void Die()
    {
        isDead = true;
        deathUI.GetComponent<Image>().DOFade(1.0f, 0.5f);
        Destroy(GameObject.FindGameObjectWithTag("EnemyGenerator"));
    }
}
