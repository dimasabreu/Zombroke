using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    public float speed = 5;
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
        Vector3 direcao = player.transform.position - transform.position;
        rb.MovePosition(rb.position + direcao.normalized * speed * Time.deltaTime);
    }
}
