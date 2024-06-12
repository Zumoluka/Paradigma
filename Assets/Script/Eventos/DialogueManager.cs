using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;

    private void Start()
    {

        dialogueText.gameObject.SetActive(false);
    }


    public void ShowDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
        dialogueText.gameObject.SetActive(true);
    }


    public void HideDialogue()
    {
        dialogueText.gameObject.SetActive(false);
    }
}
