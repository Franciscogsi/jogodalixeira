using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Mouse : MonoBehaviour
{
    //Declarando as vari�veis 
    //------ Vari�veis Publicas -------
    //Vari�vel que receber� a velocidade de acelera��o
    public float velocidade;

    //------ Vari�veis Privadas --------
    //Vari�vel que receber� o deslocamento horizontal (X)
    float deslocamentoHorizontal;

    //Vari�veis que limitaram o deslocamento horizontal
    float horizontalMaximo, horizontalMinino;

    //Essa vari�vel receber� a posi��o atual no eixo horizontal (X)
    float posicaoAtualX;

    //Vari�vel que receber� o Transform do objeto para moviment�-lo 
    Transform trtLixeira;

    //Essa vari�vel ser� usada para chamar o Script Rotacionar_Bolinha
    Rotacionar_Bolinhas pontosGanhos;


    // Start is called before the first frame update
    void Start()
    {
        velocidade = 25f;
        horizontalMaximo = 8.45f;
        horizontalMinino = -8.45f;

        trtLixeira = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Essa vari�vel receber� o deslocamento horizontal do Mouse
        //(Esquerda = (-1,0), Parado = 0 e Direita = (1,0)
        deslocamentoHorizontal = Input.GetAxisRaw("Mouse X") * velocidade;
        deslocamentoHorizontal *= Time.deltaTime;
        posicaoAtualX = this.transform.position.x;

        if (this.transform.position.x > horizontalMaximo)
        {
            this.transform.position = new Vector3(horizontalMaximo,
                                                  this.transform.position.y,
                                                  this.transform.position.z);
        }

        if (this.transform.position.x < horizontalMinino)
        {
            this.transform.position = new Vector3(horizontalMinino,
                                                  this.transform.position.y,
                                                  this.transform.position.z);
        }

        trtLixeira.position += (Vector3.right * deslocamentoHorizontal);
    }
}
