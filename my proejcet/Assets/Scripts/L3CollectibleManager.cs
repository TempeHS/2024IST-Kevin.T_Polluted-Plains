using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class L3CollectibleManager : MonoBehaviour
{
    public int collectibleCount;
    public Text collectibleText;
    public Animator fader;

    // Update is called once per frame
    void Update()
    {
        collectibleText.text = "Collectible Count: " + collectibleCount.ToString();

        if(collectibleCount == 4)
        {
            StartCoroutine(Level3Clean());
        }
    }
    
    IEnumerator Level3Clean()
    {
        Debug.Log("level 3 clean");
        fader.Play("fadeIn");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level 3 Clean");
    }
    // hardcoded :(
}
