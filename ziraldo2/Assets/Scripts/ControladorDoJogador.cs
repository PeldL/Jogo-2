using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDoJogador : MonoBehaviour
{

    public Rigidbody2D oRigidbody2D;


    public float velocidadeDaNave;

    private Vector2 teclasApertadas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();
    }


    private void MovimentarJogador()
    {

        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeDaNave;
    }



}
