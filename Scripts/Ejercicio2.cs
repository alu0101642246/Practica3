using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject b = collision.gameObject;
        Debug.Log("Ha chocado con " + b.name);
        b.GetComponent<Renderer>().material.color = Color.blue;
    }
}