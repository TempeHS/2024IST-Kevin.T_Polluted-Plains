using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchModes : MonoBehaviour
{
    public GameObject dialogueBox;
    public GameObject Continue;
    public GameObject Interact;
    public Image dBoxImage;
    public TextMeshProUGUI text;

    void Start()
    {
        Continue = dialogueBox.transform.GetChild(2).gameObject;
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
        Interact.SetActive(true);
        text.fontSize = 30;
        text.color = Color.black;
        text.alignment = TextAlignmentOptions.TopLeft;
        dBoxImage.color = new Color(255, 255, 255, 255);
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
