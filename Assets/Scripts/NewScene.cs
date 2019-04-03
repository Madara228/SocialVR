using UnityEngine;
using UnityEngine.SceneManagement;
public class NewScene : MonoBehaviour
{
    public void OpenNewScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
