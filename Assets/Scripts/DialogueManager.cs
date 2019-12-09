using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public TMP_Text dialogueText;

    public Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        dialogueText.text = "Click anywhere to start";
        
    }

    public void StartDialogue(Dialogue dialogue)
    {

        Debug.Log("Starting conversation with " + dialogue.name);
        
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        string first = sentences.Dequeue();
        dialogueText.text = first;
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);

    }

    void EndDialogue()
    {
        Debug.Log("End of convo");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        GameObject obj = GameObject.Find("Dialogue");
        obj.SetActive(false);
    }
}
