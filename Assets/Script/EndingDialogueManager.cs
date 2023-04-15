using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingDialogueManager : MonoBehaviour
{
    public EndingControl endingControl;
    public TMP_Text nameText;
    public TMP_Text dialogueText;

    public TMP_Text instructionText;

    public float typingSpeed;

    public float pauseSecond;
    private Queue<string> sentences;



    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update()
    {
        if(sentences.Count != 0 && Input.GetKeyDown("space"))
        {
            DisplayNextSentence();
        }
        if (sentences.Count == 0 && Input.GetKeyDown("f"))
        {
            endingControl.RestartGame();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        Debug.Log("Display next");
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
        dialogueText.text = "";
        instructionText.text = "";
        string textFormat = "";
        bool isTextFormat = false;
        foreach (char letter in sentence.ToCharArray())
        {
            if (letter == '>' && isTextFormat)
            {
                isTextFormat = false;
                textFormat += letter;
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
        if (sentences.Count != 0)
        {
            yield return new WaitForSeconds(pauseSecond);
            instructionText.text = "► Press SPACE to continue";
        }
        else
        {
            yield return new WaitForSeconds(pauseSecond);
            instructionText.text = "► Press F to replay";
        }
        
    }
    void EndDialogue()
    {
        Debug.Log("End reading");
    }
}
