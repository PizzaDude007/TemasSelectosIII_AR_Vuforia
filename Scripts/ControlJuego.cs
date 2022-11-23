using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    public GameObject NivelObjeto;
    //public GameObject Reinicia;
    public GameObject contadorTiempo;
    public GameObject winImage;
    public Tiempo tiempo;
    public ControlNivel NivelCodigo;
    public bool niveles, perdioNivel;
    public GameObject[] Nivel = (new GameObject[3]); //podría ser arreglo
    public Transform posNivel;
    public int nivelActual;


    // Start is called before the first frame update
    void Start()
    {
        tiempo = contadorTiempo.GetComponent<Tiempo>();
        tiempo.setTiempoRestante(80); 
        winImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        niveles = NivelCodigo.ganaste;
        if (niveles)
        {
            print("Gano, avanza a nivel"+nivelActual+1);
            if (nivelActual == 2)
            {
                nivelActual = 0;
                winImage.SetActive(true);
            }
            else
                nivelActual++;
            instanciaNivel(Nivel[nivelActual]);
            niveles = false;
        }

        perdioNivel = NivelCodigo.perdiste;
        if (perdioNivel || tiempo.TiempoRestante <= 0)
        {
            print("Perdio, nivel 0");
            nivelActual = 0;
            instanciaNivel(Nivel[nivelActual]);
            perdioNivel = false;
        }


        //instanciaNivel(Nivel1[nivelActual+1]); //modificar para que sea generico e instanciar nivel actual

        //se agrega aquí coso de tiempo para que se destruya sino pasa mucho tiempo

        //Si se pierde se instancia nivel 1 siempre, si se gana se instancia el nivel siguiente
    }
    public void instanciaNivel(GameObject nivel)
    {
        Object.Destroy(NivelObjeto);
        NivelObjeto = Instantiate(nivel, posNivel);
        //Manda a llamar el código del nivel instanciado (como arrastrar componente dentro de Inspector)
        NivelCodigo = NivelObjeto.GetComponent<ControlNivel>();
        tiempo.setTiempoRestante(80);
    }

    public void instanciaPelota()
    {
        NivelCodigo.reinicia();
    }

    //el botón podría estar aquí para que no se destruya
}
