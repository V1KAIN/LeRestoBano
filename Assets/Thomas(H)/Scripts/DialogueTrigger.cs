using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue[] Dialogue;
    public Actor[] Actors;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(Dialogue, Actors);
    }
}

[System.Serializable]
public class Dialogue
{
   public int ActorId;
   public string Message;
}

[System.Serializable]
public class Actor
{
   public string Name;
   public Sprite Sprite;
}


