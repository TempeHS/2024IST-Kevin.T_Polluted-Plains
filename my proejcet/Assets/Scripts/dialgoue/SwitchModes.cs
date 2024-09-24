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

    public bool EnableContinue;
    public bool EnableInteract;
    public int FontSize;
    public Color TextColour;
    public bool CentreTextAlignment;
    public bool TransparentDialogueBox;

    void Start()
    {
        Continue = dialogueBox.transform.GetChild(2).gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(Switch());
        }
    }

    IEnumerator Switch()
    {
        Continue.SetActive(EnableContinue);
        Interact.SetActive(EnableInteract);
        text.fontSize = FontSize;
        text.color = TextColour;
        if (CentreTextAlignment)
        {
            text.alignment = TextAlignmentOptions.Bottom;
        }
        else
        {
            text.alignment = TextAlignmentOptions.TopLeft;
        }
        
        if (TransparentDialogueBox)
        {
            dBoxImage.color = new Color(255, 255, 255, 0);
        }
        else
        {
            dBoxImage.color = new Color(255, 255, 255, 255);
        }
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
