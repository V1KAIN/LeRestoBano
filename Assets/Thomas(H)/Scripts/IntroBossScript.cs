using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBossScript : MonoBehaviour
{
    private bool hasAlreadyTalked;

    public Animator transitionAnimator;

    enum State { Intro, Outro } 
    [SerializeField]State SceneState;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pied") || other.CompareTag("Tête"))
        {
            GetComponent<DialogueTrigger>().StartDialogue();
            hasAlreadyTalked = true;
        }
    }

    private void Update()
    {
        GameObject dm = FindObjectOfType<DialogueManager>().gameObject;
        
        if (hasAlreadyTalked && dm.GetComponent<DialogueManager>().CurrentDialogueState() == false)
        {
            transitionAnimator.SetTrigger("go");
            Invoke("LoadNext",0.5f);
        }
    }

    void LoadNext()
    {
        switch (SceneState)
        {
            case State.Intro:
                MainMenuManager.LoadNextScene();        
                break;
            case State.Outro:
                MainMenuManager.LoadSceneAtIndex(0);
                break;
        }
        
        
    }
}
