using UnityEngine;

public class Ejercicio3a : MonoBehaviour
{
    public Color color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        color = other.gameObject.GetComponent<Renderer>().material.color;
        other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = color;
    }
}
