using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensColetaveis : MonoBehaviour
{
    public bool itemDeEscudo;

    public bool itemDeLaserDuplo;

    public bool itemDeVida;

    public int vidaParaDar;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {



            if (itemDeEscudo == true)
            {
                other.gameObject.GetComponent<VidaDoJogador>().AtivarEscudo();
            }

            if (itemDeLaserDuplo == true)
            {
                other.gameObject.GetComponent<ControladorDoJogador>().temLaserDuplo = true;
            }

            if (itemDeVida == true)
            {
                other.gameObject.GetComponent<VidaDoJogador>().GanharVida(vidaParaDar);
            }

            Destroy(this.gameObject);

        }
    }



}
