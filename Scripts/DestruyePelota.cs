using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DestruyePelota : MonoBehaviour
{
    //public GameObject pelota;
    public ControlJuego maestro;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "piso" || this.gameObject.transform.position.y <= -10.0)
        {
            print("choca");
            Object.Destroy(this.gameObject);
            maestro.perdioNivel = true;
        }

        //if (collision.collider.name == "nivel1")
        //{
        //    print("Pasa a nivel 2");
        //    maestro.niveles = true;
        //} 
        //else if (collision.collider.name == "nivel2")
        //{
        //    print("Pasa a nivel 3");
        //    maestro.niveles = true;
        //}
        //else if (collision.collider.name == "nivel3")
        //{
        //    print("Gana Juego");
        //    maestro.niveles = true;
        //}
    }

    //public bool activePelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
