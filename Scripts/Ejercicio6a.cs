using UnityEngine;

public class Ejercicio6a : MonoBehaviour
{
    public float speed = 3f;
    GameObject cilindro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cilindro = GameObject.FindGameObjectWithTag("Cilindro");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = cilindro.transform.position - transform.position;
        direccion.y = 0;
        direccion = direccion.normalized;
        transform.Translate(direccion * speed * Time.deltaTime, Space.World);
    }
}