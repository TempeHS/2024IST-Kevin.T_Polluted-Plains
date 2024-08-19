using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scarletslop : MonoBehaviour
{
    int amount = 5;
    public PlayerHealth playerHealth;
    public GameObject ui;
    public GameObject particle;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Rot());
            ui.SetActive(true);
            particle.SetActive(true);
        }
    }

    IEnumerator Rot()
    {
        
        for (int i = 0; i < amount; i++)
        {
            playerHealth.health -= 20;
            yield return new WaitForSeconds(1);
        }
    }
}
