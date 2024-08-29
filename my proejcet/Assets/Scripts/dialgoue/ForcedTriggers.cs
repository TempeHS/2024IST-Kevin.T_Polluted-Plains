using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcedTriggers : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public Animator DManim;
    public BoxCollider2D boxCollider;

    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(EndThought());
        }
    }

    IEnumerator EndThought()
    {
        yield return new WaitForSeconds(0.1f);
        boxCollider.enabled = false;
        yield return new WaitForSeconds(4);
        DManim.Play("out");
    }
}
