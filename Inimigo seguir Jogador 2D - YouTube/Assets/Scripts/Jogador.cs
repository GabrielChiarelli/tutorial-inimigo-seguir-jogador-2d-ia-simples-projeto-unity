using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // referência ao componente 'Rigidbody 2D' do jogador
    public Rigidbody2D oRigidbody2D;    
    
    // controla a velocidade do jogador
    public float velocidadeDoJogador;

    // identificará qual o eixo que estamos apertando (horizontal ou vertical)
    private Vector2 inputDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // chama o método 'MovimentarJogador'
        MovimentarJogador();
    }

    private void MovimentarJogador()
    {   
        // guarda os eixos apertados (horizontal ou vertical)
        inputDoJogador = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // aplica no Rigidbody 2D a velocidade do jogador na direção do eixo que apertamos
        oRigidbody2D.velocity = inputDoJogador.normalized * velocidadeDoJogador;
    }
}
