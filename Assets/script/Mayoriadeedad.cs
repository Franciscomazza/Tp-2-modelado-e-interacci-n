using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mayoriadeedad : MonoBehaviour {

   public int edadUsuario;
    public Text mitexto;



    void Start() {

       

        if(edadUsuario >= 18)
        {
            mitexto.text = "Es Mayor de edad";
            Debug.Log("es mayor de edad");
        }
        else
        {
            mitexto.text = "no es mayor de edad";
            Debug.Log(" No es mayor de edad");
        }

    }

}
