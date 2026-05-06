
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<GameObject> dusmanlar;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        GameObject[] dusmanDizisi = GameObject.FindGameObjectsWithTag("Enemy");// enemy tagýna sahip objeleri toplar

        dusmanlar = new List<GameObject>(dusmanDizisi);
    }

    public void DusmaniYokEt(GameObject yokedilecekDusman)
    {
        if (dusmanlar.Count>0)
        {
            dusmanlar.Remove(yokedilecekDusman);

            if (dusmanlar.Count==0)
            {
                UIManager.instance.FinishPaneliAc();
            }
        }
    }

}
