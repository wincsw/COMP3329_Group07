using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingDialogueManager : MonoBehaviour
{
    public EndingControl endingControl;
    public TMP_Text dialogueText;

    public TMP_Text instructionText;

    public float typingSpeed;

    public float pauseSecond;
    private Queue<string> sentences;

    public int sentenceCount = 0;



    // Start is called before the first frame update
    void Start()
    {
        sentenceCount = 0;
        // Debug.Log("endctrl " + endingControl);
        endingControl.gameObject.SetActive(true);
        sentences = new Queue<string>();
        // Debug.Log("sentences " + sentences);
    }

    void Update()
    {
        if(sentenceCount > 0 && sentences.Count != 0 && Input.GetKeyDown("space"))
        {
            DisplayNextSentence();
        }
        if (sentenceCount > 0 && sentences.Count == 0 && Input.GetKeyDown("f"))
        {
            Debug.Log("Restart Game from edm");
            endingControl.RestartGame();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        // Debug.Log("dialogue " + dialogue);
        sentenceCount = 0;
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
        sentenceCount++;
        Debug.Log("sentenceCount "+ sentenceCount);
        
    }
    void EndDialogue()
    {
        Debug.Log("End reading");
    }
}
