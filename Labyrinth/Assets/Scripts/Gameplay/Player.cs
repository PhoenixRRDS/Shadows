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
    GameObject bloodUI, deathUI, quotesUI;

    [SerializeField]
    Image healthBarUI;

    public static Player instance;
    CameraShake cameraShake;

    string[] quotes = { " \" Nature does not concern itself with good or evil, awarding the ones who are stronger in the moment \" ", " \" It's not the strongest of the species that survives, nor the most intelligent that survives. It is the one that is most adaptable to change \" - Charles Darwin ", "\"When you feel like a victim, the world finds ways to reinforce that feeling\""};

    AudioManager m_audioManager;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one player in the scene");
        }
        else {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
        isDead = false;
        currentHealth = maxHealth;
        healthBarUI.fillAmount = 0.0f;
        healthBarUI.DOFillAmount(((currentHealth * 1.0f) / maxHealth), 1.0f);

        cameraShake = CameraShake.instance;
        m_audioManager = AudioManager.instance;
        if (m_audioManager == null)
            Debug.LogError("AM IS NULL");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(int amt)
    {
        cameraShake.Shake(0.2f, 0.1f);
        currentHealth -= amt;
        if (currentHealth <= 0 && !isDead)
        {
            currentHealth = 0;
            Die();
        }
        else {
            bloodUI.GetComponent<Animation>().Play("bloodEffect");
        }
        healthBarUI.DOFillAmount(((currentHealth * 1.0f) / maxHealth), 0.5f);
    }

    void Die()
    {
        m_audioManager.PlaySound("Explode");
        isDead = true;
        deathUI.GetComponent<Image>().DOFade(1.0f, 0.5f);
        quotesUI.GetComponent<Text>().text = quotes[Random.Range(0, quotes.Length - 1)];
        quotesUI.GetComponent<Animation>().Play("quoteAnim");
        Destroy(GameObject.FindGameObjectWithTag("EnemyGenerator"));
    }

    public bool isAlive()
    {
        return !isDead;
    }
}
