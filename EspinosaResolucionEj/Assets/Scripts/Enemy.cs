using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidad = 8f;
    public float distanciaMovimiento = 0.20f;
    public bool movimientoAleatorio = false;

    private Vector3 puntoInicial;
    private int direccion = 1;

    void Start()
    {
        puntoInicial = transform.position;
    }

    void Update()
    {
        float desplazamiento;

        if (movimientoAleatorio)
        {
            desplazamiento = Mathf.Sin(Time.time * velocidad) * distanciaMovimiento;
            desplazamiento += Random.Range(-0.02f, 0.02f);
        }
        else
        {
            desplazamiento = Mathf.Sin(Time.time * velocidad) * distanciaMovimiento;
        }

        transform.position = new Vector3(puntoInicial.x + desplazamiento, puntoInicial.y, puntoInicial.z);
    }
}
