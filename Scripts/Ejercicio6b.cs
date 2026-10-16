using UnityEngine;

public class Ejercicio6b : MonoBehaviour
{

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
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
