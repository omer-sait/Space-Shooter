
using UnityEngine;
using UnityEngine.UI;





public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;    

    [SerializeField] int maxSaglik = 10;
    int gecerliSaglik;

    [SerializeField] Image healthFill;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gecerliSaglik = maxSaglik;

        HealthBarGuncelle();

    }

    public  void HasarAl(int hasarMiktarý)
    {
        gecerliSaglik -= hasarMiktarý;

        gecerliSaglik = Mathf.Clamp(gecerliSaglik, 0, maxSaglik);

        HealthBarGuncelle();

        if(gecerliSaglik <= 0 )
        {
            UIManager.instance.GameOverPaneliAc();
            SoundManager.instance.PlayerPatlamaSesiCýkar();
            gameObject.SetActive(false);
        }
    }

    

    void HealthBarGuncelle()
    {
        float canMiktarý = (float) gecerliSaglik / maxSaglik;

        healthFill.fillAmount = canMiktarý;
    }

    
}
