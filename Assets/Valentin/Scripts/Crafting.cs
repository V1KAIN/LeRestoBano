using System;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour
{
    public GameObject Burger1, Burger2;
    public GameObject Wrap1, Wrap2;
    public GameObject Octaburger1, Octaburger2 ;
    public GameObject Nonburger1, Nonburger2 ;
    public GameObject CheeseBurger1, CheeseBurger2;

    public Text Pain, Galette, Viande, Poulet, Bacon, Fromage, Ketchup, Mayo, Frite;

    private void Update()
    {
        Pain.text = InventoryScript.Pain.ToString();
        Galette.text = InventoryScript.Galette.ToString();
        Viande.text = InventoryScript.Steak.ToString();
        Poulet.text = InventoryScript.Poulet.ToString();
        Bacon.text = InventoryScript.Bacon.ToString();
        Fromage.text = InventoryScript.Fromage.ToString();
        Ketchup.text = InventoryScript.Ketchup.ToString();
        Mayo.text = InventoryScript.Mayo.ToString();
        Frite.text = InventoryScript.Frite.ToString();
    }

    public void Craft()
    {
        if (InventoryScript.Pain >= 1 && InventoryScript.Steak >= 8 && InventoryScript.Mayo >= 1
            && InventoryScript.Ketchup >= 1 && InventoryScript.Frite >= 1 && InventoryScript.Bacon >= 1)
        {
            InventoryScript.Pain -= 1;
            InventoryScript.Steak -= 8;
            InventoryScript.Mayo -= 1;
            InventoryScript.Ketchup -= 1;
            InventoryScript.Frite -= 1;
            InventoryScript.Bacon -= 1;
            Octaburger1.SetActive(true);
            Octaburger2.SetActive(true);
        } 
        else if (InventoryScript.Galette >= 1 && InventoryScript.Poulet >= 1 && InventoryScript.Mayo >= 1)
        {
            InventoryScript.Galette -= 1;
            InventoryScript.Poulet -= 1;
            InventoryScript.Mayo -= 1;
            Wrap1.SetActive(true);
            Wrap2.SetActive(true);
        }
        else if (InventoryScript.Pain >= 1 && InventoryScript.Steak >= 1 && InventoryScript.Fromage >= 1)
        {
            InventoryScript.Pain -= 1;
            InventoryScript.Steak -= 1;
            InventoryScript.Fromage -= 1;
            CheeseBurger1.SetActive(true);
            CheeseBurger2.SetActive(true);
        }
        else if (InventoryScript.Pain >= 1 && InventoryScript.Steak >= 1)
        {
            InventoryScript.Pain -= 1;
            InventoryScript.Steak -= 1;
            Burger1.SetActive(true);
            Burger2.SetActive(true);
        }
        else if (InventoryScript.Pain >= 1)
        {
            InventoryScript.Pain -= 1;
            Nonburger1.SetActive(true);
            Nonburger2.SetActive(true);
        }
    }
}
