using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float eixoX;
    private float eixoZ;
    private Vector3 direcao;
    [SerializeField] private int velocidade = 10;
    private  Animator animator;
    private Rigidbody rb;

    public LayerMask MascaraChao;
    public GameObject textoPerdeu;
    public bool Vivo = true;
    private void Start() 
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
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

        if(Vivo == false)
        {
            if(Input.GetButton("Fire1"))
            {
                SceneManager.LoadScene("Hotel_outside");
            }
        }
    }
    private void FixedUpdate() {
        rb.MovePosition(rb.position + (direcao * velocidade * Time.deltaTime));

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 100, Color.red);

        RaycastHit impacto;

        if(Physics.Raycast(raio, out impacto, 100, MascaraChao))
        {
            Vector3 posicaoMiraJogador = impacto.point - transform.position;


            Quaternion novaRotacao = Quaternion.LookRotation(posicaoMiraJogador);

            rb.MoveRotation(novaRotacao);
        }
    }
}