using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;
    private Animator anim;

    public PlayerMovement playerMovement; // to get player movement script
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;

        playerMovement = FindObjectOfType<PlayerMovement>(); // also to get the variables from the player movement script
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        anim.SetBool("isDead", true);
        playerMovement.speed = 0;
        playerMovement.jumpingPower = 0;
        StartCoroutine(Dying());
    }

    IEnumerator Dying()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel(Application.loadedLevel);
    }
}
