using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{
    public GameObject pelotaActiva;
    public GameObject ReiniciaBoton;
    public GameObject pelota;
    public Transform inicioPelota;
    public bool ganaste;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(pelota, inicioPelota);
    }

    public void OnTriggerEnter(Collider other)
    {
        print("ganaste");
        ganaste = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pelota, inicioPelota); //cada que se presione espacio se genera pelota
        }*/

        if (pelotaActiva == null)
        {
            //perdio(); //se quitó el botón
            reinicia(); //crea nueva pelota
        }
    }

    public void reinicia()
    {
        pelotaActiva = Instantiate(pelota, inicioPelota);

        ReiniciaBoton.SetActive(false);
    }

    public void perdio() //no se está ocupando
    {
        ReiniciaBoton.SetActive(true);
    }
}
