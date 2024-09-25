using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class WinGame : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    public GameObject winText;

    // Update is called once per frame
    void Update()
    {
        if (dialogue.text == "yahoo!")
        {
            winText.SetActive(true);
            StartCoroutine(Quit());
        }
    }

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
    }
}
