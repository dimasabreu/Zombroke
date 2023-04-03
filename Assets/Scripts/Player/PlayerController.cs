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
    void Update()
    {
        
        eixoX = Input.GetAxis("Horizontal");
        eixoZ = Input.GetAxis("Vertical");
        direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
}
