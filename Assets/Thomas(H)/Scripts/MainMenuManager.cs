using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{ 
   [SerializeField] Animator transitionAnimator;
   
   public void QuitGame()
   {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
      
   }

   public void LaunchGame()
   {
      transitionAnimator.SetTrigger("go");
      Invoke(nameof(LGInvoke), .5f);
   }

   private void LGInvoke()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public static void LoadSceneAtIndex(int index)
   {
      SceneManager.LoadScene(index);
   }
   
   public static void LoadNextScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
