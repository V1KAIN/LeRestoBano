using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOnTrigger : MonoBehaviour
{
    public bool Benjamin;
    public GameObject Benjamin1, Benjamin2, Benjamin3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pied") && Benjamin)
        {
            GetComponent<DialogueTrigger>().StartDialogue();
            Benjamin1.SetActive(false);
            Benjamin2.SetActive(true);
        }
        
        if (other.CompareTag("Tête") && Benjamin && InventoryScript.Burger == true)
        {
            InventoryScript.Burger = false;
            Benjamin2.SetActive(false);
            Benjamin3.SetActive(true);
        }
    }
}
