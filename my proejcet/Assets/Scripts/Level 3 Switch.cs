using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Level3Switch : MonoBehaviour
{
    public TextMeshProUGUI dialogue;

    // Update is called once per frame
    void Update()
    {
        if (dialogue.text == "kachow")
        {
            SceneManager.LoadScene("Level 3");
        }
    }
}
