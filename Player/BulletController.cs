using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float hiz = 10f;

    [SerializeField] GameObject effect;

    private void Update()
    {
        transform.Translate(Vector3.up * hiz * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Meteor"))
        {
            Instantiate(effect, transform.position,Quaternion.identity);
            SoundManager.instance.MeteorPatlamaSesiCýkar();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }       
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
