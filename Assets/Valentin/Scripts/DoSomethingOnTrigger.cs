using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoSomethingOnTrigger : MonoBehaviour
{
    public string SceneName;

    public Animator animator;

    public bool Bas, Haut;
    public bool Comptoir, Frigo;

    public GameObject CraftPanel;
    public GameObject FrigoPanel;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tête") && Bas)
        {
            animator.SetTrigger("go");
            Invoke("Transition",0.5f);
        }
        if (other.CompareTag("Pied") && Haut)
        {
            animator.SetTrigger("go");
            Invoke("Transition",0.5f);
        }
        if (other.CompareTag("Pied") && Comptoir)
        {
            CraftPanel.SetActive(true);
            Target.isInMenu = true;
        }    
        if (other.CompareTag("Pied") && Frigo)
        {
            FrigoPanel.SetActive(true);
            Target.isInMenu = true;
        }    
    }

    public void Transition()
    {
        SceneManager.LoadScene(SceneName);
    }
}
