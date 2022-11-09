using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject pelota;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "piso")
        {
            print("choca");
            Object.Destroy(this.gameObject);
        }
    }

    public bool activePelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
