using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBoxFloatingCanvas : MonoBehaviour
{
    [SerializeField] DialogueBox dialogueBox = null;
    [SerializeField] GameObject icon = null;

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.gameObject.SetActive(false);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        dialogueBox.gameObject.SetActive(true);
        icon.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        dialogueBox.gameObject.SetActive(false);
        icon.SetActive(true);
    }
}
