using UnityEngine;
using UnityEngine.SceneManagement;
public class PLAY : MonoBehaviour
{
   public void play()
   {
    SceneManager.LoadScene(1);
   }
   public void quit()
   {
   SceneManager.LoadScene(0);
   }
}
