using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOnTrigger : MonoBehaviour
{
    public static bool Ben ;
    public static bool Ric1, Ric2;
    public static bool Bos1, Bos2; 
    
    public bool Benjamin;
    public GameObject Benjamin1, Benjamin2, Benjamin3;
    public bool Richard;
    public GameObject Richard1, Richard2, Richard3;
    public bool Boss;
    public GameObject Boss1, Boss2, Boss3;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //benj
        if (other.CompareTag("Pied") && Benjamin)
        {
            Ben = true;
            GetComponent<DialogueTrigger>().StartDialogue();
            Destroy(Benjamin1);
            Benjamin2.SetActive(true);
        }
        
        if (other.CompareTag("Tête") && Benjamin && InventoryScript.Burger == true)
        {
            Ben = false;
            InventoryScript.Burger = false;
            Destroy(Benjamin2);
            Benjamin3.SetActive(true);
        }
        
        //Rich
        if (other.CompareTag("Pied") && Richard)
        {
            Ric2 = true;
            GetComponent<DialogueTrigger>().StartDialogue();
            Destroy(Richard1);
            Richard2.SetActive(true);
        }
        
        if (other.CompareTag("Tête") && Richard && InventoryScript.Wrap == true)
        {
            Ric2 = false;
            InventoryScript.Wrap = false;
            Destroy(Richard2);
            Richard3.SetActive(true);
        }
        
        //boss
        if (other.CompareTag("Pied") && Boss)
        {
            Bos2 = true;
            GetComponent<DialogueTrigger>().StartDialogue();
            Destroy(Boss1);
            Boss2.SetActive(true);
        }
        
        if (other.CompareTag("Tête") && Boss && InventoryScript.OctaB == true)
        {
            Bos2 = false;
            Bos1 = false;
            Ben = false;
            Ric1 = false;
            Ric2 = false;
            InventoryScript.OctaB = false;           
            Debug.Log("Gagné");
        }
    }

    private void Start()
    {
        if (Ben)
        {
            Destroy(Benjamin1);
            Benjamin2.SetActive(true);
        } 
        if (Ric1)
        {
            Destroy(Benjamin1);
            Destroy(Benjamin2);
            Destroy(Benjamin3);
            Richard1.SetActive(true);
        }
        if (Ric2)
        {
            Destroy(Benjamin1);
            Destroy(Benjamin2);
            Destroy(Benjamin3);
            Destroy(Richard1);
            Richard2.SetActive(true);
        }
        if (Bos1)
        {
            Destroy(Benjamin1);
            Destroy(Benjamin2);
            Destroy(Benjamin3);
            Destroy(Richard1);
            Destroy(Richard2);
            Destroy(Richard3);
            Boss1.SetActive(true);
        }
        if (Bos2)
        {
            Destroy(Benjamin1);
            Destroy(Benjamin2);
            Destroy(Benjamin3);
            Destroy(Richard1);
            Destroy(Richard2);
            Destroy(Richard3);
            Destroy(Boss1);
            Boss2.SetActive(true);
        }
        
    }

    public void RichGo()
    {
        Ric1 = true;
        Richard1.SetActive(true);
    }
    public void BossGo()
    {
        Bos1 = true;
        Boss1.SetActive(true);
    }
}
