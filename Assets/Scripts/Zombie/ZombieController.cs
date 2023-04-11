using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    public float speed = 5;
    private Quaternion Rotation;
    private Vector3 direcao;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        

        float distancia = Vector3.Distance(transform.position, player.transform.position);

        if(distancia > 1.6f)
        {
            direcao = player.transform.position - transform.position;
            rb.MovePosition(rb.position + direcao.normalized * speed * Time.deltaTime);
            
            Rotation = Quaternion.LookRotation(direcao);
            rb.MoveRotation(Rotation);
        }
        
    }
}
