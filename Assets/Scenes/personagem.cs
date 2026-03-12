using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentcao : MonoBehaviour
{
    int frameAtual = 0;
    int inicioPulo = 0;
    bool pulando = false;

    
    void Start()
    {

    }

    
    void Update()
    {
        frameAtual = frameAtual + 1;

        // Faz boneco andar para frente
        if (Input.GetKey("d"))
        {
            this.transform.Translate(0.05f, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            this.transform.Translate(-0.05f, 0, 0);
        }

        if (Input.GetKey("w") && Physics.CheckSphere(transform.position, 2f) && pulando == false)
        {
            // inicio do pulo
            inicioPulo = frameAtual;
            pulando = true;
        }

        int framesPassados = frameAtual - inicioPulo;

        if (pulando == true)
        {
            if ((framesPassados < 100))
            {
                this.transform.Translate(0, 0.05f, 0);
            }
            else
            {
                pulando = false;
            }
        }
    }
}