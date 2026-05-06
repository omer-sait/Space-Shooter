using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] AudioSource mouseClik;
    [SerializeField] AudioSource enemyExplosion;
    [SerializeField] AudioSource meteorExplosion;
    [SerializeField] AudioSource playerExplosion;

    private void Awake()
    {
        instance = this;
    }

    public void mouseClikSesiCýkar()
    {
        mouseClik.Play();
    }
    public void EnemyPatlamaSesiCýkar()
    {
        enemyExplosion.Play();
    }
    public void PlayerPatlamaSesiCýkar()
    {
        playerExplosion.Play();
    }
    public void MeteorPatlamaSesiCýkar()
    {
        meteorExplosion.Play();
    }
    
}
