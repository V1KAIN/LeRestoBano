using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;

    private Dialogue[] _currentMessages;
    private Actor[] _currentActors;
    private int activeMessage = 0;

    //Démarre la conversation
    public void OpenDialogue(Dialogue[] messages, Actor[] actors)
    {
        _currentMessages = messages;
        _currentActors = actors;
        activeMessage = 0;
        DisplayDialogue();
        Debug.Log("Started conversation, Loaded " + messages.Length + " messages between " + actors.Length + " actors" );
    }
    
    //Passe au prochain message de la conversation 
    public void NextDialogue()
    {
        //Augmente le 
        activeMessage++;
        //Regarde si le message actif est le dernier
        if(activeMessage < _currentMessages.Length){ DisplayDialogue();} 
        else { Debug.Log("Conversation Ended!");}
    }
    
    //Affiche les informations de la conversation(Avatar, Nom et message de la personne qui parle) dans la boîte de dialogue
    void DisplayDialogue()
    {
        Dialogue dialogueToDisplay = _currentMessages[activeMessage];
        messageText.text = dialogueToDisplay.Message;

        Actor actorToDisplay = _currentActors[dialogueToDisplay.ActorId];
        actorName.text = actorToDisplay.Name;
        actorImage.sprite = actorToDisplay.Sprite;
    }
}
