using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2beething : MonoBehaviour
{
    // hardcoded :(
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Level 2 (bee spawn)");
        }
    }
}
