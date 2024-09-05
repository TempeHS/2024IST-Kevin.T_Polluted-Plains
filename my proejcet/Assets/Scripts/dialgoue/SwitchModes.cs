using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchModes : MonoBehaviour
{
    public GameObject dialogueBox;
    public GameObject Continue;
    public Image dBoxImage;

    void Start()
    {
        Continue = dialogueBox.transform.GetChild(2).gameObject;
        dBoxImage = gameObject.GetComponent<Image>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(SwitchToNormal());
        }
    }

    IEnumerator SwitchToNormal()
    {
        Continue.SetActive(true);
        dBoxImage.color = new Color(255, 255, 255, 255);
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
