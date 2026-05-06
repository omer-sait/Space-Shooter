

using UnityEngine;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject finishPanel;



    bool oyunDurkalatildimi = false;

    public object ScenceManager { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseDurumuDegistir();

        }
    }

    private void PauseDurumuDegistir()
    {
        oyunDurkalatildimi = !oyunDurkalatildimi;

        if(oyunDurkalatildimi)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
        }
    }

    public void PausePaneliAc()
    {
        if (!oyunDurkalatildimi)
        {
            PauseDurumuDegistir();
        }
    }

    public void PausePaneliKapat()
    {
        if (oyunDurkalatildimi)
        {
            PauseDurumuDegistir();
        }
    }

    internal void GameOverPaneliAc()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void TekrarOyna()
    {
        SoundManager.instance.mouseClikSesiCýkar();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }

    internal void FinishPaneliAc()
    {
        finishPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void AnaMenuyeDon()
    {
        SoundManager.instance.mouseClikSesiCýkar();
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
