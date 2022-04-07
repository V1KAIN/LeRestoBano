using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroBossScript : MonoBehaviour
{
    private bool hasAlreadyTalked;

    public Animator transitionAnimator;
    
    public enum IOSceneState { Intro, Outro }

    public IOSceneState IOState; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pied") || other.CompareTag("Tête"))
        {
            GetComponent<DialogueTrigger>().StartDialogue();
            hasAlreadyTalked = true;
        }
    }

    private GameObject dm;

    private void Start()
    {
        dm = FindObjectOfType<DialogueManager>().gameObject;
    }

    private void Update()
    {
        if (hasAlreadyTalked && dm.GetComponent<DialogueManager>().CurrentDialogueState() == false)
        {
            transitionAnimator.SetTrigger("go");
            Invoke("LoadNext",0.5f);
        }
    }

    void LoadNext()
    {
        switch (IOState)
        {
            case IOSceneState.Intro: MainMenuManager.LoadNextScene();
                break;
            case IOSceneState.Outro: MainMenuManager.LoadSceneAtIndex(6);
                break;
        }
        
        
    }
}
