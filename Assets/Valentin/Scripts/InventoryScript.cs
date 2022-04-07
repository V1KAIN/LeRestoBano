using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public static int Ketchup;
    public static int Mayo;
    public static int Steak;
    public static int Bacon;
    public static int Poulet;
    public static int Pain;
    public static int Galette;
    public static int Fromage;
    public static int Frite;

    public static bool Burger = false;
    public static bool Wrap = false;
    public static bool OctaB = false;
    public static bool NonBurger = false;
    public static bool CheeseBurger = false;

    public static void ResetInventory()
    {
        Ketchup = 0;
        Mayo = 0;
        Steak = 0;
        Bacon = 0;
        Poulet = 0;
        Pain = 0;
        Galette = 0;
        Fromage = 0;
        Frite = 0;

        Burger = false;
        Wrap = false;
        OctaB = false;
        NonBurger = false;
        CheeseBurger = false;
    }
}
