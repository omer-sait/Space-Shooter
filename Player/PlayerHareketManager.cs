using UnityEngine;

public class PlayerControllerManager : MonoBehaviour
{
    [Header("Elementler")]
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawn;


    [Header("Ayarlar")]
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float minX = -4f;
    [SerializeField] float maxX = 4f;
    [SerializeField] float mÝnY = -7.5f;
    [SerializeField] float maxY = 2f;




    private void Update()
    {
        HareketFNC();

        //mermi fýrlatma
        if (Input.GetMouseButtonDown(0)) 
        {
            MermiFirlatFNC();
        }

    }

    private void HareketFNC()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 hareketVectoru = new Vector3(h, v, 0);
        hareketVectoru = hareketVectoru.normalized;  //çapraz giderken daha hýzlý gitmrsini engeller

        transform.Translate(hareketVectoru * moveSpeed * Time.deltaTime);

        Vector3 clampPos = transform.position;

        clampPos.x = Mathf.Clamp(clampPos.x, minX, maxX);
        clampPos.y = Mathf.Clamp(clampPos.y, mÝnY, maxY);

        transform.position = clampPos;
    }

    void MermiFirlatFNC()
    {
        // mermiyi olluþturuyoruz
        Instantiate(bulletPrefab, bulletSpawn.position ,Quaternion.identity);
    }
}
