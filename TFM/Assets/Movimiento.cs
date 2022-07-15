using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Vector3 direccion;
    private float Distancia_Limite = 0.6f;
    public float Velocidad = 20.0f;
    private Rigidbody rb;
    public LayerMask Etiqueta_Tope;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direccion = -transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direccion * Velocidad;
        if(Physics.Raycast(transform.position, transform.forward, Distancia_Limite, Etiqueta_Tope))
        {
            Velocidad = 0f;
        }
    }
}
