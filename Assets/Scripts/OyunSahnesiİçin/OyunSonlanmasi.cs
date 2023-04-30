using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonlanmasi : MonoBehaviour
{
   
    public GameObject DonenCember;
    public GameObject SpawnLokasyonu;

  

    public void GameOver()
    {
        DonenCember.GetComponent<DonenBuyukCember>().enabled = false;
        //oyun bittikten sonra dönemesin daha fazla.Bu kod DonenBuyukCember script'ini kapatır.
        SpawnLokasyonu.GetComponent<CubukSpawner>().enabled = false;
        //oyun bittikten sonra sol tıkla daha fazla çubuk spawn'lamasın diye.CubukSpawner script'ini kapatır.
    }
}
