using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    public GameObject NivelObjeto;
    public ControlNivel NivelCodigo;
    public bool niveles;
    public GameObject Nivel1, Nivel2, Nivel3; //podría ser arreglo
    public Transform posNivel;
    public int nivelActual;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        niveles = NivelCodigo.ganaste;
        if (niveles)
            instanciaNivel(Nivel1);
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
    }

    //el botón podría estar aquí para que no se destruya
}
