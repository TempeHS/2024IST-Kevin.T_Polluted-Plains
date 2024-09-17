using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerVariables : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject HealthBar;
    public GameObject CollectibleCount;

    public float playerSpeed;
    public float playerJumpingPower;
    public bool activateHealth;
    public bool activateCollectibleCount;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerMovement.speed = playerSpeed;
            playerMovement.jumpingPower = playerJumpingPower;
            if (activateHealth)
            {
                HealthBar.SetActive(true);
            }
            if (activateCollectibleCount)
            {
                CollectibleCount.SetActive(true);
            }
        }
    }
}
