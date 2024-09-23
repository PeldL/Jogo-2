using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDoInimigo : MonoBehaviour
{ 
    public float velocidadeDoLaser;

    public int danoParaDar;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarLaser();
    }

    private void MovimentarLaser()
    {
        transform.Translate(Vector3.up * velocidadeDoLaser * Time.deltaTime);
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponente<VidaDoJogador>().MachucarJogador(danoParaDar);
        }

    }


    
}
