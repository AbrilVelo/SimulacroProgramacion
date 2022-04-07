using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{

    //Crear las variables necesarias para ingresar por 
    //el precio de 3 productos y un monto de dinero disponible.
    //si la suma de los mismos supera o no el monto de dinero disponible.
    //Luego indicar cuánto dinero sobra o falta.

    public float precio1;
    public float precio2;
    public float precio3;
    public float montoDisponible;


    void Start()
    {
        float conjunto = precio1 + precio2 + precio3;
        float sobra;
        float falta;

        if (conjunto < montoDisponible)
        {
            sobra = montoDisponible - conjunto;
            Debug.Log("Los precios de los productos no supera el monto de dinero disponible, sobran $" + sobra);
        }
        else if (conjunto > montoDisponible)
        {
            falta = conjunto - montoDisponible;
            Debug.Log("Los precios de los productos supera el monto de dinero disponible, faltan $" + falta);
        }
        else if (conjunto == montoDisponible)
        {
            Debug.Log("Los precios de los productos no supera el monto de dinero disponible, faltan $0");
        }

    }

    
}
