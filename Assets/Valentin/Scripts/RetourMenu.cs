using UnityEngine.SceneManagement;
using UnityEngine;

public class RetourMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject Panel;

    public void PanelGo()
    {
        Panel.SetActive(true);
        Target.isInMenu = true;
    }
    public void Non()
    {
        //Target.isInMenu = false;
        Panel.SetActive(false);
    }
    public void Oui()
    {
        animator.SetTrigger("go");
        Invoke("GoMenu", 0.5f);
    }

    private void GoMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
    }
    
}
