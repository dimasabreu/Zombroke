using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 20;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * bulletSpeed * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider objetoDeColisao) 
    {
        if(objetoDeColisao.tag == "Inimigo")
            Destroy(objetoDeColisao.gameObject);
        
        Destroy(gameObject);
    }

}
