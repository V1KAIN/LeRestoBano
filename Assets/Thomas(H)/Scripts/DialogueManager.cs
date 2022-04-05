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

    [Header("Parameters")]
    [SerializeField] KeyCode NextMessageKey = KeyCode.Space;
    [SerializeField] KeyCode PreviousMessageKey = KeyCode.Backspace;
    [SerializeField] private bool CanGoBackMessages = true;
        
    //Privates Fields    
    private Dialogue[] _currentMessages;
    private Actor[] _currentActors;
    private int _activeMessage = 0;

    private bool _isInDialogue = false;

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
            }
        }
    }
    
    public void PreviousDialogue()
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
    
    //Affiche les informations de la conversation(Avatar, Nom et message de la personne qui parle) dans la boîte de dialogue
    void DisplayDialogue()
    {
        Dialogue dialogueToDisplay = _currentMessages[_activeMessage];
        messageText.text = dialogueToDisplay.Message;

        Actor actorToDisplay = _currentActors[dialogueToDisplay.ActorId];
        actorName.text = actorToDisplay.Name;
        actorImage.sprite = actorToDisplay.Sprite;
    }
}
