using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public void RestartGame()
    {
        // В редакторе юнити после перезапуска игры рендер теней слетает
        // связано с багом юнити редактора и в проде такой проблемы нет
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadInstagram()
    {
        Application.OpenURL("https://www.instagram.com/per.pointt/");
    }
}
