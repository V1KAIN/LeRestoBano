using System;
using UnityEngine;

public class Object : MonoBehaviour
{
    
    public bool Steak, Bacon, Poulet, Ketchup, Mayo, Pain, Galette, Fromage, Frite, Burger, Wrap, OctaB, NonBurger;


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
            InventoryScript.Poulet += 1;
            Destroy(gameObject);
        }
        if (other.CompareTag("Pied") && Bacon)
        {
            InventoryScript.Bacon += 1;
            Destroy(gameObject);
        }
        if (other.CompareTag("Main") && Frite)
        {
            InventoryScript.Frite += 1;
            Destroy(gameObject);
        }
        if (other.CompareTag("Main") && Pain)
        {
            InventoryScript.Pain += 1;
            Destroy(gameObject);
        }
        if (other.CompareTag("Main") && Galette)
        {
            InventoryScript.Galette += 1;
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && Mayo)
        {
            InventoryScript.Mayo += 1;
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && Ketchup)
        {
            InventoryScript.Ketchup += 1;
            Destroy(gameObject);
        }
        
        if (other.CompareTag("Torse") && Burger)
        {
            InventoryScript.Burger = true;
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && OctaB)
        {
            InventoryScript.OctaB = true;
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && NonBurger)
        {
            InventoryScript.NonBurger = true;
            Destroy(gameObject);
        }
        if (other.CompareTag("Torse") && Wrap)
        {
            InventoryScript.Wrap = true;
            Destroy(gameObject);
        }
    }

    public void AddFromage()
    {
        InventoryScript.Fromage += 1;
    }
    public void AddSteak()
    {
        InventoryScript.Steak += 1;
    }
}
