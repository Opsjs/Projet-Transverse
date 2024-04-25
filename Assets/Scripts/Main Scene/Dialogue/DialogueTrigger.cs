using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void Update()
    {

    }
    private void OnMouseDown()
    {

        TriggerDialogue();
    }
        void TriggerDialogue()
        {
            DialogueManager.instance.StartDialogue(dialogue);
        }
}