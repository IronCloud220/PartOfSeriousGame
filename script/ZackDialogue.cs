using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZackDialogue : MonoBehaviour
{
    public GameObject Dialogue;
    public Text DialogueText;
    public string[] dialogue;
    public bool dialogueActive;
    public int dialogueTime;

    // Update is called once per frame
    void Update()
    {
        //if(Contact1.distanceTravelled <= BackgroundChange.crust)
        //{
        //    Dialogue.SetActive(false);
        //}
        if (Contact1.distanceTravelled > BackgroundChange.crust && Contact1.distanceTravelled <= BackgroundChange.crust + dialogueTime)//add
        {
            DialogueText.text = dialogue[0];
            Dialogue.SetActive(true);
        }
        else if (Contact1.distanceTravelled > BackgroundChange.crust + dialogueTime && Contact1.distanceTravelled < BackgroundChange.mantle)
        {
            Dialogue.SetActive(false);
        }

        else if (Contact1.distanceTravelled > BackgroundChange.mantle && Contact1.distanceTravelled <= BackgroundChange.mantle + dialogueTime)
        {
            DialogueText.text = dialogue[1];
            Dialogue.SetActive(true);
            

        }
        else if (Contact1.distanceTravelled > BackgroundChange.mantle + dialogueTime)
        {
            Dialogue.SetActive(false);
        }

        else if (Contact1.distanceTravelled > BackgroundChange.outercore && Contact1.distanceTravelled <= BackgroundChange.mantle + dialogueTime)
        {
            Dialogue.SetActive(true);
            DialogueText.text = dialogue[2];
            
        }
        else if (Contact1.distanceTravelled > BackgroundChange.mantle + dialogueTime)
        {
            Dialogue.SetActive(false);
        }

        else if (Contact1.distanceTravelled > BackgroundChange.innercore && Contact1.distanceTravelled <= BackgroundChange.mantle + dialogueTime)
        {
            DialogueText.text = dialogue[3];
            Dialogue.SetActive(true);
        }
        else if (Contact1.distanceTravelled > BackgroundChange.mantle + dialogueTime)
        {
            Dialogue.SetActive(false);
        }
    }
}
