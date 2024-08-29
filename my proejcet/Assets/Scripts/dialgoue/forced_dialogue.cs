using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forced_dialogue : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;
    public DialogueManager dialogueManager;
    public Animator anim;

    void Start()
    {
        dialogueTrigger = FindObjectOfType<DialogueTrigger>();
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dialogueTrigger.TriggerDialogue();
            StartCoroutine(Touched());
        }
    }

    IEnumerator Touched()
    {
        Debug.Log("tocuehd");
        Destroy(GetComponent<BoxCollider2D>());
        yield return new WaitForSeconds(3);
        Debug.Log("done");
        anim.Play("out");
    }
}
