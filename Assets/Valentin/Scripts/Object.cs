using System;
using UnityEngine;

public class Object : MonoBehaviour
{
    
    public bool Steak, Bacon, Poulet, Ketchup, Mayo, Pain, Galette, Fromage, Frite, Burger, Wrap, OctaB, NonBurger, CheeseBurger;


    private void Update()
    {
        if (Bacon && InventoryScript.Bacon >= 1) gameObject.SetActive(false);
        if (Poulet && InventoryScript.Poulet >= 1) gameObject.SetActive(false);
        if (Ketchup && InventoryScript.Ketchup >= 1) gameObject.SetActive(false);
        if (Mayo && InventoryScript.Mayo >= 1) gameObject.SetActive(false);
        if (Pain && InventoryScript.Pain >= 1) gameObject.SetActive(false);
        if (Galette && InventoryScript.Galette >= 1) gameObject.SetActive(false);
        if (Frite && InventoryScript.Frite >= 1) gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pied") && Poulet)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            GetComponent<DialogueTrigger>().StartDialogue();
            InventoryScript.Poulet += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("poulet");
            Destroy(gameObject);
        }
        if (other.CompareTag("Pied") && Bacon)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            GetComponent<DialogueTrigger>().StartDialogue();
            InventoryScript.Bacon += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("bacon");
            Destroy(gameObject);
        }
        if (other.CompareTag("Main") && Frite)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Frite += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("frite");
            Destroy(gameObject);
        }
        if (other.CompareTag("Main") && Pain)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Pain += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("pain");
            Destroy(gameObject);
        }
        if (other.CompareTag("Main") && Galette)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Galette += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("galette");
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && Mayo)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Mayo += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("mayo");
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && Ketchup)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Ketchup += 1;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("ketchup");
            Destroy(gameObject);
        }
        
        if (other.CompareTag("Torse") && Burger)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Burger = true;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("burger");
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && OctaB)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.OctaB = true;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("menu octomachin");
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && NonBurger)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.NonBurger = true;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("non burger");
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && Wrap)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.Wrap = true;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("wrap");
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && CheeseBurger)
        {
            FindObjectOfType<AudioManager>().PitchAlea("Plus");
            InventoryScript.CheeseBurger = true;
            other.GetComponentInParent<PopUpTextScript>().SpawnText("cheese burger");
            Destroy(gameObject);
        }
    }

    public void AddFromage()
    {
        InventoryScript.Fromage += 1;
        FindObjectOfType<AudioManager>().PitchAlea("Plus");
    }
    public void AddSteak()
    {
        InventoryScript.Steak += 1;
        FindObjectOfType<AudioManager>().PitchAlea("Plus");
    }
}
