using UnityEngine;
using UnityEngine.UI; // Only needed if using UI Text
// using TMPro; // Uncomment if using TextMeshPro

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueUI; // The UI GameObject for the dialogue
    // public TMP_Text dialogueText; // Uncomment if using TextMeshPro

    void Start()
    {
        // Show the dialogue at the start
        dialogueUI.SetActive(true);

        // If you want to set the text dynamically:
        // dialogueText.text = "Welcome! Walk into the area to continue.";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Make sure it's the player
        if (other.CompareTag("Player"))
        {
            // Hide the dialogue when player enters the trigger
            dialogueUI.SetActive(false);
        }
    }
}
