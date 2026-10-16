using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{
    public int damage = 0; 
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
        damage += 50;
        Debug.Log("Se hizo " + damage + " de daño.");
    }
}
