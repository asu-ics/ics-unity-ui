using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] GameObject image = null;
    [SerializeField] GameObject imageName = null;

    [SerializeField] Text[] messages = null;

    private int messageIdx;

    // Start is called before the first frame update
    void Start()
    {
        messageIdx = 2;
        SetActiveText(messageIdx);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetActiveText(int idx)
    {
        foreach(Text message in messages)
        {
            message.gameObject.SetActive(false);
        }

        messages[idx].gameObject.SetActive(true);
    }

    public void ScrollRight()
    {
        if (messageIdx < messages.Length -1)
        {
            messageIdx += 1;
            SetActiveText(messageIdx);
        }

        else
        {
            messageIdx = 0;
            SetActiveText(messageIdx);
        }
    }

    public void ScrollLeft()
    {
        if (messageIdx > 0)
        {
            messageIdx -= 1;
            SetActiveText(messageIdx);
        }

        else
        {
            messageIdx = messages.Length - 1;
            SetActiveText(messageIdx);
        }
    }
}
