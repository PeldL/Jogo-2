using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public AudioSource musicaDoJogo;
    public AudioSource musicaDeGameOver;
    public Text textoDePontuacaoAtual;
    public GameObject painelDeGameOver;
    public Text textoDePontuacaofinal;
    public Text textoDeHighScore;

    public int pontuacaoAtual;

  


   
    void Awake()
    {
        instance = this;    
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        musicaDoJogo.Play();

        pontuacaoAtual = 0;  
        textoDePontuacaoAtual.text = "PONTUA��O: " + pontuacaoAtual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        pontuacaoAtual += pontosParaGanhar;
        textoDePontuacaoAtual.text = "PONTUA��O: " + pontuacaoAtual;
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        musicaDoJogo.Stop();
        musicaDeGameOver.Play();

        painelDeGameOver.SetActive(true);
        textoDePontuacaofinal.text = "PONTUA��O: " + pontuacaoAtual;

        if(pontuacaoAtual > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", pontuacaoAtual);

        }

        textoDeHighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");
    }

}
