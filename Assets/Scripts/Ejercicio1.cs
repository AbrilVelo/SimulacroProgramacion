using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    //Crea un programa que permita ingresar por 
    //Inspector dos valores enteros y responda si son iguales o no lo son.

    public int num1;
    public int num2;

    void Start()
    {



        if (num1 > num2)
        {
            Debug.Log("El numero 1 es mayor");
        }

        if (num2 > num1)
        {
            Debug.Log("El numero 2 es mayor");
        }
        if (num1 == num2)
        {
          Debug.Log("Los numeros son iguales");
        }
        
               
       
    }

    
}
