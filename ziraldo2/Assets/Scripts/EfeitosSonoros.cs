using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitosSonoros : MonoBehaviour
{

    public static EfeitosSonoros instance;

    public AudioSource somDaExplosao, somDoLazerDoJogaor, somDeImpacto;

   void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
