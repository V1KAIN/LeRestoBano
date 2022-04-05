using UnityEngine;
using UnityEngine.SceneManagement;
public class DoSomethingOnTrigger : MonoBehaviour
{
    public string SceneName;

    public Animator animator;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("go");
            Invoke("Transition",0.5f);
        }
    }

    public void Transition()
    {
        SceneManager.LoadScene(SceneName);
    }
}
