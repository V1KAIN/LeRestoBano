using UnityEngine;

public class Object : MonoBehaviour
{
    
    public bool Steak;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pied") && Steak)
        {
            InventoryScript.Steak += 1;
            Destroy(gameObject);
        }
    }
}
