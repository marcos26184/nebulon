using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo1 : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMinima;
    public float velocidadeMaxima;

    private float velocidadeY;
    // Start is called before the first frame update
    void Start()
    {
        this.velocidadeY = Random.Range(this.velocidadeMinima, this.velocidadeMaxima);

    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2(0, -this.velocidadeY);
    }

    public void Destruir()    {
        ControledePontos.Pontos++;
        Destroy(this.gameObject);
    }
      
}
