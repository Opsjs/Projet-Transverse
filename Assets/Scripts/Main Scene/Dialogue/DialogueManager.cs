using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public static DialogueManager instance;

    [SerializeField] Button answerButton;

    public bool InDialogue = false;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("il y a plus d'une instance de DialogueManager dans la scene");
            return;
        }

        instance = this;

        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        InDialogue = true;

        nameText.text = dialogue.name;

        switch (nameText.text)
        {
            case "Matteo":
                if (!Enigme2.isCorrect)
                {
                    answerButton.gameObject.SetActive(true);
                } else
                {
                    answerButton.gameObject.SetActive(false);
                }
                break;
            case "Nina":
                if (!Enigme3.isCorrect)
                {
                    answerButton.gameObject.SetActive(true);
                }
                else
                {
                    answerButton.gameObject.SetActive(false);
                }
                //SceneManager.LoadScene("Enigme3");
                break;
            case "Nathalie":
                if (!Enigme4.isCorrect)
                {
                    answerButton.gameObject.SetActive(true);
                }
                else
                {
                    answerButton.gameObject.SetActive(false);
                }
                //Condition Énigme fille ok
                //SceneManager.LoadScene("Enigme4");
                break;
        }



        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
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
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    void EndDialogue()
    {
        InDialogue= false;
        animator.SetBool("IsOpen", false);
    }
}