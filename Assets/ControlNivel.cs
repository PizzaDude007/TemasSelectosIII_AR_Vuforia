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

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(pelota, inicioPelota);
    }

    public void OnTriggerEnter(Collider other)
    {
        print("ganaste");
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
            perdio();
        }
    }

    public void reinicia()
    {
        pelotaActiva = Instantiate(pelota, inicioPelota);

        ReiniciaBoton.SetActive(false);
    }

    public void perdio()
    {
        ReiniciaBoton.SetActive(true);
    }
}
