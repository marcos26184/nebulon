using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NaveJogador : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMovimento;

    public laser laserPrefab;
    public float tempoEsperaTiro;
    private float intervaloTiro;


    public Transform[] posicoesArmas;
    private Transform armaAtual;



    // Start is called before the first frame update
    void Start()
    {
        intervaloTiro = 0;
        this.armaAtual = this.posicoesArmas[0];
        ControledePontos.Pontos = 0;


    }

    // Update is called once per frame
    void Update()
    {
        this.intervaloTiro += Time.deltaTime;
        if (this.intervaloTiro >= this.tempoEsperaTiro){
            this.intervaloTiro = 0;
            Atirar();
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);

        this.rigidbody.velocity = new Vector2(velocidadeX, velocidadeY);
    }

    private void Atirar()
    {
        Instantiate(this.laserPrefab, this.armaAtual.position, Quaternion.identity);
        if (this.armaAtual == this.posicoesArmas[0])
        {
            this.armaAtual = this.posicoesArmas[1];
        }
        else
        {
            this.armaAtual = this.posicoesArmas[0];
        }
    }

}
