using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;

    public Animator animator;
    public Animator playerAnimator;

    public float typingSpeed;

    private Queue<string> sentences;
    public bool isActive;



    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        sentences = new Queue<string>();
    }

    void Update()
    {
        if (!FindObjectOfType<PlayerMovement>().enabled && Input.GetKeyDown("space"))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        isActive = true;
        Debug.Log("isActive: " + isActive);
        playerAnimator.SetFloat("Speed", 0f);
        FindObjectOfType<PlayerMovement>().enabled = false;
        animator.SetBool("IsOpen", true);
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        // Debug.Log("Display next");
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        string textFormat = "";
        bool isTextFormat = false;
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            if (letter == '>' && isTextFormat)
            {
                isTextFormat = false;
                textFormat += letter;
                // Debug.Log(textFormat);
                dialogueText.text += textFormat;
                textFormat = "";
                continue;
            }
            if (letter == '<' || isTextFormat)
            {  
                isTextFormat = true;
                textFormat += letter;
                continue;
            }
            dialogueText.text += letter;
            if (isTextFormat)
            {
                yield return null;
            }
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    void EndDialogue()
    {
        isActive = false;
        // Debug.Log("isActive: " + isActive);

        Debug.Log("End reading");
        animator.SetBool("IsOpen", false);
        FindObjectOfType<PlayerMovement>().enabled = true;
    }

}
