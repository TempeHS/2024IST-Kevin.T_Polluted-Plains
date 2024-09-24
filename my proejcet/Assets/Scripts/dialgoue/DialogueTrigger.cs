using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueCharacter
{
    public string name;
}
 
[System.Serializable]
public class DialogueLine
{
    public DialogueCharacter character;
    [TextArea(3, 10)]
    public string line;
}
 
[System.Serializable]
public class Dialogue
{
    public List<DialogueLine> dialogueLines = new List<DialogueLine>();
}

public class DialogueTrigger : MonoBehaviour
{
    public Animator DManim;

    public Dialogue dialogue;
 
    public void TriggerDialogue()
    {
        DialogueManager.Instance.StartDialogue(dialogue);
    }

    public bool playerIsClose;
    public bool interact;

    public bool forceDialogue;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerIsClose = false;
            DManim.Play("out");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            interact = true;
        }
        else
        {
            interact = false;
        }

        if (playerIsClose && forceDialogue)
        {
            TriggerDialogue();
        }
        else if (playerIsClose && interact)
        {
            TriggerDialogue();
        }
    }
}
