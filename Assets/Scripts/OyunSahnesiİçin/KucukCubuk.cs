using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubuk  : MonoBehaviour
{
// Çubuğun tek amacı yukarı doğru git ve büyük objenin child objesi olsun.Yani o da onunla beraber onun bir parçası gibi dönsün.

    Rigidbody2D rb;
    public float speed;
    public bool HareketKısıtlımı;
    public GameObject OyunSonuİcin;
    public static bool oyunbitti;

    void Start()
    {
        OyunSonuİcin = GameObject.FindGameObjectWithTag("OyunSonuIcin");
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (HareketKısıtlımı == false)
        {

            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
            //küçük çemberin sürekli yukarı doğru hareket etmesini sağlayan kod.
        }
    }

   void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.tag == "DonenCember") 
        {
            transform.SetParent(collison.transform);//temas ettiğin objenin child objesi ol.
            HareketKısıtlımı = true;
            //trigger yani içinden geçme açıksa bile temas ettiğin anda dur. İçinden geçme.
        }
        if (collison.gameObject.tag == "KucukCember")
        {
            oyunbitti = true;
            OyunSonuİcin.GetComponent<OyunSonlanmasi>().GameOver();
         //önce objenin içindeki scripte, sonra ise scripteki fonksiyona eriştik.
        }
    }
}
