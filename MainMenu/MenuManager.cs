using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OyunaBasla()
    {
        SoundManager.instance.mouseClikSesiCýkar();

        SceneManager.LoadScene("Level_1");
    }

    public void OyundanCýk()
    {
        SoundManager.instance.mouseClikSesiCýkar();

        Application.Quit();
    }
}
