using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class DialogueForEach : MonoBehaviour
{
    public GameObject Dialogue;
    public Text DialogueText;
    public string dialogue;
   // public bool dialogueActive;
    public int dialogueTime;
    public int levelNumber1, levelNumber2;
    public Text nameText;
    public Image zack;
    public Image bg;

    void Start()
    {
        DialogueText.gameObject.SetActive(false);
        nameText.gameObject.SetActive(false);
        bg.gameObject.SetActive(false);
        zack.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Contact1.distanceTravelled > levelNumber1 && Contact1.distanceTravelled <= levelNumber1 + dialogueTime)//add
        {
            DialogueText.text = dialogue;
            DialogueText.gameObject.SetActive(true);
            nameText.gameObject.SetActive(true);
            bg.gameObject.SetActive(true);
            zack.gameObject.SetActive(true);
        }
        else if (Contact1.distanceTravelled > levelNumber1 + dialogueTime && Contact1.distanceTravelled < levelNumber2)
        {
            Dialogue.SetActive(false);
        }
        
    }
    
}
