using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    public GameObject zumbi;
    float contadorTempo = 0;
    public float tempoGerarZumbi = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorTempo += Time.deltaTime;

        if(contadorTempo > tempoGerarZumbi)
        {
            Instantiate(zumbi, transform.position, transform.rotation);
            contadorTempo = 0;

        }
    }
}
