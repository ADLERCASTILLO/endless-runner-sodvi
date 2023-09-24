using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public Renderer fondo; //variable para el fondo
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //Ajustando velocidad del fondo:
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.015f,0) * Time.deltaTime;
    }
}
