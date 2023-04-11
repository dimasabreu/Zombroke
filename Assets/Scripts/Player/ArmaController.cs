using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaController : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private GameObject BulletSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        }
    }
}
