using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    public GameObject CheeseBurger1, CheeseBurger2;
    public GameObject Wrap1, Wrap2;
    public GameObject Octaburger1, Octaburger2 ;
    public GameObject Nonburger1, Nonburger2 ;

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
        else if (InventoryScript.Pain >= 1 && InventoryScript.Steak >= 1)
        {
            InventoryScript.Pain -= 1;
            InventoryScript.Steak -= 1;
            CheeseBurger1.SetActive(true);
            CheeseBurger2.SetActive(true);
        }
        else if (InventoryScript.Pain >= 1)
        {
            InventoryScript.Pain -= 1;
            Nonburger1.SetActive(true);
            Nonburger2.SetActive(true);
        }
    }
}
