using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusHealth : MonoBehaviour
{
    private GameManager gameManager;

    public int maxHealth;
    public int currentHealth;

    public GameObject[] healthBolts;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        currentHealth = maxHealth;
    }

    public void TakeDamange()
    {
        currentHealth--;
        healthBolts[currentHealth].gameObject.SetActive(false);
        if (currentHealth <= 0)
        {
            gameManager.GameOver();
        }
    }
}
