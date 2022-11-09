using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{
    public GameObject pelota;

    public Transform inicioPelota;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(pelota, inicioPelota);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pelota, inicioPelota); //cada que se presione espacio se genera pelota
        }
    }
}
