using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar_Bolinhas : MonoBehaviour
{
    //------ Vari�veis Privadas --------
    //Essa vari�vel ser� usada para definir uma acelera��o de rota��o
    float aceleracao;
    //Essa vari�vel do tipo vetor ser� usada para rotacinar a bolinha
    Vector3 rotacaoX;

    //Essa vari�vel ser� usada para chamar o Script Controlar_Textos
    Controlar_Textos controlarPontos;


    // Start is called before the first frame update
    void Start()
    {
        aceleracao = 100f;
        rotacaoX = new Vector3(0f, 0f, (aceleracao * Time.deltaTime));

        //Inicializa a vari�vel controlarPontos recebendo todas as 
        //propriedades e comportamentos do Script Controlar_Textos
        controlarPontos = FindObjectOfType(typeof(Controlar_Textos)) as Controlar_Textos;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotacaoX);

        if (this.transform.position.y < -5.8f)
        {
            controlarPontos.PerderPontos(gameObject.tag);
            Destroy(this.gameObject);

        }
    }

    public void ControlarPontosGanhos(GameObject objeto)
    {
        controlarPontos.GanharPontos(objeto.tag);
        if (objeto.tag != "Untagged")
        {
            Destroy(objeto);
        }
    }
}
