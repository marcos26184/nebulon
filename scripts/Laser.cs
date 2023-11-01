using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeY;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody.velocity = new Vector2(0, this.velocidadeY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Inimigo"))  {
            inimigo1 inimigo = collider.GetComponent<inimigo1>();
            inimigo.Destruir();
            Destroy(this.gameObject);// destruindo o laser

        }
        
    }

}
