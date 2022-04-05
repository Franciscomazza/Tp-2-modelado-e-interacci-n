using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Validarcontraseña : MonoBehaviour
{

    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public GameObject cartelitoMsj;
    public Text textoMjs;
    
    // Start is called before the first frame update
    void Start(){
        contraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

   
    public void Validarcontrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMjs.text = "bienvenido";
            Debug.Log ("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMjs.text = "contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");


        }



    }

}
