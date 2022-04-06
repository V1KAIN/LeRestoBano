using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    public GameObject CheeseBurger;
    public GameObject Wrap;
    public GameObject Octaburger;

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
            Octaburger.SetActive(true);
        } 
        else if (InventoryScript.Pain >= 1 && InventoryScript.Steak >= 1)
        {
            InventoryScript.Pain -= 1;
            InventoryScript.Steak -= 1;
            CheeseBurger.SetActive(true);
        }
    }
}
