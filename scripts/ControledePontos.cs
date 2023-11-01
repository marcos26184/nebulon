using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ControledePontos
{

    private static int pontos;

    public static int Pontos  {
        get
        {
            return pontos; //retorna o valor da pontuacao
        }
        set { //altera o valor e garante que nao vai ser menor que zero
            pontos = value; 
            if (pontos <0)
            {
                pontos = 0; 
            }
            Debug.Log("pontuação atualizada para: " + pontos);
              }
    }
}
    