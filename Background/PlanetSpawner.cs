using System.Collections;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    [Header("Ayarlar")]
    [SerializeField] float minX = -3f;
    [SerializeField] float maxX = 3f;
    [SerializeField] float sabitY = 12f;
    [SerializeField] float firlatmaSüresi = 10f;

    [Header("Elementler")]
    [SerializeField] GameObject[] gezegenPrefabs;

    private void Start()
    {
        StartCoroutine(GezegenFirlatRoutine());
    }

    IEnumerator GezegenFirlatRoutine()
    {
        while (true)
        {
            float rasgeleX = Random.Range(minX, maxX);

            Vector3 firlatmaPos = new Vector3(rasgeleX, sabitY, 0);

            int rasgeleIndex = Random.Range(0, gezegenPrefabs.Length);

            GameObject gezegenPrefab =  Instantiate(gezegenPrefabs[rasgeleIndex], firlatmaPos,Quaternion.identity);

            Destroy(gezegenPrefab,25 );

            yield return new WaitForSeconds(firlatmaSüresi);
        }
    }
}
