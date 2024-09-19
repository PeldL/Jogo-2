using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDoJogador : MonoBehaviour
{

    public Rigidbody2D oRigidbody2D;


    public GameObject laserDoJogardor;


    public Transform localDoDisparoUnico;



    public float velocidadeDaNave;


    public bool temLaserDuplo;


    private Vector2 teclasApertadas;


    // Start is called before the first frame update
    void Start()
    {
        temLaserDuplo = false;
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



    private void AtirarLaser()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (temLaserDuplo == false)
            {

                Instantiate(laserDoJogardor, localDoDisparoUnico.position, localDoDisparoUnico.rotation);
            } 

        }

    }


}
