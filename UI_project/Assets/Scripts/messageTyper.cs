using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageTyper : MonoBehaviour
{
    [SerializeField] string[] lines;
    [SerializeField] int lettersPerSecond = 45;
    [SerializeField] Text messageText;

    private bool isTyping = false;
    private int currentLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        // quick fix so it doesn't skip the first message
        currentLine = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightButton()
    {
        if (isTyping) { return; }

        if (currentLine < lines.Length-1)
        {
            currentLine++;
            StartCoroutine(TypeLine(lines[currentLine]));
        }
    }

    public void LeftButton()
    {
        if (isTyping) { return; }

        if (currentLine > 0)
        {
            currentLine--;
            StartCoroutine(TypeLine(lines[currentLine]));
        }
    }

    private IEnumerator ShowDialogue()
    {
        yield return new WaitForEndOfFrame();

        if (currentLine < lines.Length)
        {
            StartCoroutine(TypeLine(lines[currentLine]));
            currentLine++;
        }

        else
        {
            currentLine = 0;
        }

    }

    private IEnumerator TypeLine(string line)
    {
        isTyping = true;

        messageText.text = "";
        foreach (var letter in line.ToCharArray())
        {
            messageText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }

        isTyping = false;
    }
}
