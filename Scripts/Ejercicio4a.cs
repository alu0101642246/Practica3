using UnityEngine;

public class Ejercicio4a : MonoBehaviour
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
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemigos"))
        {
            Debug.Log(collision.gameObject.name + " me ha atacado");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Recolectables"))
        {
            Debug.Log("He detectado " + other.gameObject.name);
        }
    }
}