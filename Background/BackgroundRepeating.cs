
using UnityEngine;

public class Repeat : MonoBehaviour
{
    [SerializeField] float yukseklik;

    private void Update()
    {
        if (transform.position.y <-yukseklik)
        {
            PoszisyonuGuncelle();
        }
    }

    private void PoszisyonuGuncelle()
    {
        Vector2 pos =  new Vector2(0, yukseklik * 2);
        transform.position = (Vector2) transform.position + pos;
    }
}
