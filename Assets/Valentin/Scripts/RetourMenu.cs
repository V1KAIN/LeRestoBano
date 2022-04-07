using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RetourMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject Panel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Tête")) PanelGo();
    }

    public void PanelGo()
    {
        Panel.SetActive(true);
        Target.isInMenu = true;
    }
    public void Non()
    {
        Target.isInMenu = false;
        Panel.SetActive(false);
    }
    public void Oui()
    {
        animator.SetTrigger("go");
        Invoke("GoMenu", 0.5f);
    }

    private void GoMenu()
    {
        InventoryScript.ResetInventory();
        SceneManager.LoadScene("MainMenu");
    }
    
}
