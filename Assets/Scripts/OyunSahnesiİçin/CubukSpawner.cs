using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubukSpawner : MonoBehaviour
{
    public GameObject stick;

   

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // GetMouseButton mouse'da sol tık GetMouseButtonDown ise her basıldığında bi kere çalıştır.
        {
            StickSpawn();
        }
        
    }

    void StickSpawn()
    {
        Instantiate(stick, transform.position, transform.rotation);
    }
}
