using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float eixoX;
    private float eixoZ;
    private Vector3 direcao;
    [SerializeField]
    private int velocidade = 10;
    private  Animator animator;
    private Rigidbody rb;
    private void Start() 
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
    
        eixoX = Input.GetAxis("Horizontal");
        eixoZ = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);

        


        if(direcao != Vector3.zero)
        {
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
    }
    private void FixedUpdate() {
        rb.MovePosition(rb.position + (direcao * velocidade * Time.deltaTime));
    }
}
