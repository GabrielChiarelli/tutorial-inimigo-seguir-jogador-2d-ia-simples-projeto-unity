using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // referência ao componente 'Transform' do jogador
    private Transform posicaoDoJogador;

    // controla a velocidade do jogador
    public float velocidadeDoInimigo;

    // Start is called before the first frame update
    void Start()
    {
        // guarda o componente 'Transform' do jogador na variável 'posicaoDoJogador'
        posicaoDoJogador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // chama o método 'SeguirJogador'
        SeguirJogador();
    }

    private void SeguirJogador()
    {
        // verifica se o gameObject do jogador está ativado na aba 'Hierarquia'
        if(posicaoDoJogador.gameObject != null)
        {
            // move o gameObject do inimigo na direção do jogador, utilizando sua velocidade
            transform.position = Vector2.MoveTowards(transform.position, posicaoDoJogador.position, velocidadeDoInimigo * Time.deltaTime);
        }
    }
}
