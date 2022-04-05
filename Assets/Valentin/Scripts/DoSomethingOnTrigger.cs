using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoSomethingOnTrigger : MonoBehaviour
{
    public string SceneName;

    public Animator animator;

    public bool Bas, Haut;
    public bool Comptoir;

    public GameObject CraftPanel;
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
    }

    public void Transition()
    {
        SceneManager.LoadScene(SceneName);
    }
}
