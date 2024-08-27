using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public bool interactable;
    public GameObject video;
    public Animator interactAnim;
    public Animator fader;
    public GameObject openedDoor;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && interactable)
        {
            Debug.Log("clicked");
            StartCoroutine(EnableVideo());        
        }

        if (video.activeSelf)
        {
            interactAnim.Play("out");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactable = false;
        }
    }

    IEnumerator EnableVideo()
    {
        Debug.Log("enable video");
        fader.Play("fadeIn");
        yield return new WaitForSeconds(0.3f);
        video.SetActive(true);
        fader.Play("fadeOut");
        yield return new WaitForSeconds(8);
        fader.Play("fadeIn");
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Level 2");
    }
}
