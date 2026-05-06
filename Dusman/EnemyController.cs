using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform[] hedefler;
    public float harekwetHizi = 5f;

    int mevcutHedefIndex = 0;

    public int hasarMiktarý = 3;

    private void Update()
    {
        if (hedefler.Length == 0) return;

        transform.position = Vector3.MoveTowards(transform.position, hedefler[mevcutHedefIndex].position, harekwetHizi * Time.deltaTime);

        if (Vector3.Distance(transform.position, hedefler[mevcutHedefIndex].position)< 1f  )
        {
            mevcutHedefIndex++;

            if (mevcutHedefIndex >= hedefler.Length)
            {
                mevcutHedefIndex = 0;
                transform.position = hedefler[mevcutHedefIndex].position;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            GameManager.instance.DusmaniYokEt(this.gameObject);
            SoundManager.instance.EnemyPatlamaSesiCýkar();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.DusmaniYokEt(this.gameObject);
            PlayerHealth.instance.HasarAl(hasarMiktarý);
            Destroy(this.gameObject);
        }
    }


        
    
}
