using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonenBuyukCember : MonoBehaviour
{
    public float speed;
    void Start() //buraya yazılanlar sadece oyunun başında çalışanlar.
    {
        
    }

    
    void Update() //sürekli çalışanlar buraya yazılır.
    {
        transform.Rotate(0, 0, speed * Time.deltaTime); //delta time kısmını kullanıyoruz çünkü bu çember pcde de mobilde de aynı hızda dönsün.
        //yoksa pcde daha yavaş dönerken mobilde çok daha hızlı döner.(rotate=dönmek,döndürmek).

    }
}
