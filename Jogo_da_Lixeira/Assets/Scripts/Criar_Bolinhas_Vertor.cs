using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criar_Bolinhas_Vertor : MonoBehaviour
{
    //Declarando as variáveis 
    //------ Variáveis Publicas -------
    //Esse vetor receberá os Prefabs das bolinhas
    public GameObject[] bolinhas = new GameObject[3];
    //Tempo entra a criação das boinhas 
    public float tempo;


    //------ Variáveis Privadas --------
    //Essa variável receberá uma instância da bolinha de papel que será criada
    GameObject criarBolinha;
    //Quantidade de bolinhas a ser criadas
    int numeroBolas;
    //Controle do laço de repetição While
    int controle;
    //Posição onde a bolinha deverá ser criada no eixo x e eixo y
    float posicaoX, posicaoY;
    //Escolher bolinha
    int escolha;

    // Start is called before the first frame update
    void Start()
    {
        tempo = 1f;
        //Método usado para criar as bolinhas
        //Assinatura: (Nome do método, tempo de espera para
        //comçar a criar as bolinha (2 segundos) e frequência
        //de repetição (1 segundo))
        InvokeRepeating("CriarBolinhas", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CriarBolinhas()
    {
        posicaoX = Random.Range(-8.5f, 8.5f);
        posicaoY = Random.Range(5.5f, 8.0f);
        escolha =  Random.Range(0, 3);

        //Instacia a bola de papel 
        criarBolinha = Instantiate(bolinhas[escolha]);
        //Determina em que posição a bolinha será criada
        criarBolinha.transform.position = new Vector2(posicaoX, posicaoY);
    }
}
