using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncy : MonoBehaviour
{
    [SerializeField] public Rigidbody2D playerRb;
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerRb.velocity = new Vector2(0, 15);
        }
    }
}
