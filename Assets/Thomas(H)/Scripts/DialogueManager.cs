using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Drag & Drop")]
    public Image actorImage;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;
    [SerializeField] private GameObject DialogueContentHolder;

    [Header("Parameters")]
    [SerializeField] KeyCode NextMessageKey = KeyCode.Space;
    [SerializeField] KeyCode PreviousMessageKey = KeyCode.Backspace;
    [SerializeField] private bool CanGoBackMessages = true;
    [SerializeField] private float typingSpeed = 0.04f;
    
    
        
    //Privates Fields    
    private Dialogue[] _currentMessages;
    private Actor[] _currentActors;
    private int _activeMessage = 0;
    private Animator DialogueBoxAnimator;

    private bool _isInDialogue = false;

    private void Start()
    {
        DialogueBoxAnimator = gameObject.GetComponent<Animator>();
        DesactivateDCH();
    }

    private void Update()
    {
        if (Input.GetKeyDown(NextMessageKey))NextDialogue();
        if(Input.GetKeyDown(PreviousMessageKey)) PreviousDialogue(); 
    }

    //Démarre la conversation
    public void OpenDialogue(Dialogue[] messages, Actor[] actors)
    {
        _currentMessages = messages;
        _currentActors = actors;
        _activeMessage = 0;
        _isInDialogue = true;
        DialogueContentHolder.SetActive(true);
        DisplayDialogue();
        Debug.Log("Started conversation, Loaded " + messages.Length + " messages between " + actors.Length + " actors" );
    }
    
    //Passe au prochain message de la conversation 
    public void NextDialogue()
    {
        //Regarde si le joueur est dans un dialogue 
        if(_isInDialogue){
            _activeMessage++;  
            if(_activeMessage < _currentMessages.Length){
                //Augmente l'index du dialogue
                DisplayDialogue();
            }
            //Regarde si le message actif est le dernier
            else
            { 
                Debug.Log("Conversation Ended!");
                _isInDialogue = false;
                DialogueBoxAnimator.SetBool("GoOut", true);
                Invoke(nameof(DesactivateDCH), .20f); 
            }
        }
    }
    
    public void PreviousDialogue()
    {
        if (CanGoBackMessages)
        {
            //Regarde si le joueur est dans un dialogue 
            if(_isInDialogue){
                //Si le nombre de message est supérieur a 0 il revient au message précédent
                if (_activeMessage > 0)
                {
                    _activeMessage--;
                    DisplayDialogue();
                } 
            }
        }
    }
    
    //Affiche les informations de la conversation(Avatar, Nom et message de la personne qui parle) dans la boîte de dialogue
    void DisplayDialogue()
    {
        Dialogue dialogueToDisplay = _currentMessages[_activeMessage];
        //messageText.text = dialogueToDisplay.Message;
        if(displayLineCoroutine != null) StopCoroutine(displayLineCoroutine);      
        displayLineCoroutine = StartCoroutine(DisplayLine(dialogueToDisplay.Message));

        Actor actorToDisplay = _currentActors[dialogueToDisplay.ActorId];
        actorName.text = actorToDisplay.Name;
        actorImage.sprite = actorToDisplay.Sprite;
    }


    private Coroutine displayLineCoroutine;
    private IEnumerator DisplayLine(string line)
    {
        //enleve le dialogue précédent
        messageText.text = "";
        
        //Affiche un lettre a la fois
        foreach (char letter in line.ToCharArray())
        {
            messageText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void DesactivateDCH()
    {
        DialogueContentHolder.SetActive(false);
        DialogueBoxAnimator.SetBool("GoOut",false);
    }
}
