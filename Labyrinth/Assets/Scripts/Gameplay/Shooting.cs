using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    Camera cam;

    [SerializeField]
    GameObject hitParticle, enemyHitParticles, muzzleFlash;

    [SerializeField]
    Transform shootPoint;

    int m_damageAmt = 50;
    
	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject _muzzleFlash = Instantiate(muzzleFlash, shootPoint.position, Quaternion.identity);
            //Destroy(_muzzleFlash, 1.0f);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    GameObject explosion;
                    if (hit.collider.gameObject.tag == "Enemy")
                    {
                        Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();
                        enemy.TakeDamage(m_damageAmt);
                        explosion = Instantiate(enemyHitParticles, hit.point, Quaternion.identity);
                    }
                    else
                    {
                        explosion = Instantiate(hitParticle, hit.point, Quaternion.identity);
                    }
                    Destroy(explosion, 2.0f);
                }
            }
        }
	}
}
