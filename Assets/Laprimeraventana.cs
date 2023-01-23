using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laprimeraventana : MonoBehaviour{
    public string sitio1 = "http://www.udgvirtual.udg.mx/";
    public string sitio2 = "https://www.udgvirtual.udg.mx/servicios-escolares";
    public string sitio3 = "https://siiau.udg.mx/";

    public void Laprimeraventana (){
        Application.OpenURL (sitio1);
                Application.OpenURL (sitio2);
                        Application.OpenURL (sitio3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
