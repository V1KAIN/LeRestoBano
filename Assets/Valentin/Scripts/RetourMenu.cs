using UnityEngine.SceneManagement;
using UnityEngine;

public class RetourMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject Panel;

    public void PanelGo()
    {
        Target.isInMenu = true;
        Panel.SetActive(true);

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
        Target.isInMenu = false;
        SceneManager.LoadScene("MainMenu");
    }
}
