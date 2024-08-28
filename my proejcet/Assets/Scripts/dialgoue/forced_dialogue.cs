using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forced_dialogue : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;

    void Start()
    {
        dialogueTrigger = FindObjectOfType<DialogueTrigger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dialogueTrigger.TriggerDialogue();
        }
    }
}
