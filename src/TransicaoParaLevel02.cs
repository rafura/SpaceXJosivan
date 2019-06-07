﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoParaLevel02 : MonoBehaviour
{
    float larguraTela;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer grafico = GetComponent<SpriteRenderer>();

        float larguraImagem = grafico.sprite.bounds.size.x;
        float alturaImagem = grafico.sprite.bounds.size.y;

        float alturaTela = Camera.main.orthographicSize * 2;
        larguraTela = alturaTela / Screen.height * Screen.width;

        Vector2 novaEscala = transform.localScale;
        novaEscala.x = (larguraTela / larguraImagem);
        novaEscala.y = alturaTela / alturaImagem;

        this.transform.localScale = novaEscala;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Level02");                       
        }
    }
}
