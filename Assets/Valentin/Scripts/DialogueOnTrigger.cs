using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOnTrigger : MonoBehaviour
{
    public static bool Ben ;
    public static bool Ric;
    
    public bool Benjamin;
    public GameObject Benjamin1, Benjamin2, Benjamin3;
    public bool Richard;
    public GameObject Richard1, Richard2, Richard3;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //benj
        if (other.CompareTag("Pied") && Benjamin)
        {
            GetComponent<DialogueTrigger>().StartDialogue();
            Destroy(Benjamin1);
            Benjamin2.SetActive(true);
            Ben = true;
        }
        
        if (other.CompareTag("Tête") && Benjamin && InventoryScript.Burger == true)
        {
            InventoryScript.Burger = false;
            Destroy(Benjamin2);
            Benjamin3.SetActive(true);
        }
        
        //Rich
        if (other.CompareTag("Pied") && Richard)
        {
            GetComponent<DialogueTrigger>().StartDialogue();
            Destroy(Richard1);
            Richard2.SetActive(true);
            Ric = true;
        }
        
        if (other.CompareTag("Tête") && Richard && InventoryScript.Wrap == true)
        {
            InventoryScript.Wrap = false;
            Destroy(Richard2);
            Richard3.SetActive(true);
        }
    }

    private void Start()
    {
        if (Ben)
        {
            Benjamin1.SetActive(false);
            Benjamin2.SetActive(true);
        } 
        if (Ric)
        {
            Richard1.SetActive(false);
            Richard2.SetActive(true);
        } 
    }
}
