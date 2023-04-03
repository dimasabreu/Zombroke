using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float eixoX;
    float eixoZ;
    Vector3 direcao;
    void Update()
    {
        
        eixoX = Input.GetAxis("Horizontal");
        eixoZ = Input.GetAxis("Vertical");
        direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao);
    }
}
