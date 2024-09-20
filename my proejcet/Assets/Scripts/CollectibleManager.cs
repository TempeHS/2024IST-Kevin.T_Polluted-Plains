using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleManager : MonoBehaviour
{
    public int collectibleCount;
    public Text collectibleText;
    public GameObject newBee;
    public GameObject oldBee;
    public GameObject changeDialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collectibleText.text = "Collectible Count: " + collectibleCount.ToString();

        if(collectibleCount == 3)
        {
            oldBee.SetActive(false);
            newBee.SetActive(true);
            changeDialogue.SetActive(true);
        }
    }
}
