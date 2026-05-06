using UnityEngine;

public class DamageKontroller : MonoBehaviour
{
    public int HasarMiktarý = 2;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.instance.HasarAl(HasarMiktarý);

            Destroy(gameObject);
        }
    }
}
