
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelmanger: MonoBehaviour
{
    public void NextLevel()
    { 
    
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
