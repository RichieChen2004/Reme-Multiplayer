using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);
    }
}
