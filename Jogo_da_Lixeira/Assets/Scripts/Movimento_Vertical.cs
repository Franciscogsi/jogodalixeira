using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Vertical : MonoBehaviour
{
    //Declarando as vari�veis 
    //------ Vari�veis Publicas -------
    //Vari�vel que receber� a velocidade de acelera��o
    public float velocidade;

    //------ Vari�veis Privadas --------
    //Vari�vel que receber� o deslocamento vertical (Y)
    float deslocamentoVertical;

    //Vari�veis que limitaram o deslocamento vertical
    float verticalMaximo, verticalMinino;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10f;
        verticalMaximo = 4.3f;
        verticalMinino = -4.3f;
    }

    // Update is called once per frame
    void Update()
    {
        deslocamentoVertical = Input.GetAxis("Vertical") * velocidade;
        deslocamentoVertical *= Time.deltaTime;

        this.transform.Translate(0f, deslocamentoVertical, 0f);

        if (this.transform.position.y > verticalMaximo)
        {
            this.transform.position = new Vector3(this.transform.position.x,
                                                  verticalMaximo,
                                                  this.transform.position.z);
        }

        if (this.transform.position.y < verticalMinino)
        {
            this.transform.position = new Vector3(this.transform.position.x,
                                                  verticalMinino,
                                                  this.transform.position.z);
        }

    }
}
