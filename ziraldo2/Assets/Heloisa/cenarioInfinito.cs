using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenarioInfinito : MonoBehaviour
{
    public float velocidadedocenario;

    // Update is called once per frame
    void Update()
    {
        MovimentaCenario();
    }
    private void MovimentaCenario ()
    {
        Vector2  deslocamentoDoCenario = new Vector2(Time.time * velocidadedocenario, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamentoDoCenario;
    }
}
