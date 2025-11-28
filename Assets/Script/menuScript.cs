using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void triggerMenu(int trigger)
    {
        switch (trigger)
        {
            case 0:
                Debug.Log("Chargement scène GameScene");
                SceneManager.LoadScene("GameScene");
                break;
            case 1:
                Application.Quit();
                break;
        }
    }
}
