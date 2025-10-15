using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float minForce = 12f, 
        maxForce = 16f,
        maxTorque = 10f, 
        xRange = 4f,
        ySpawnPos = -6f;
    
    
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(RandomForce(), ForceMode.Impulse);
        _rigidbody.AddTorque(RandomTorque(), RandomTorque(),
            RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    
    /// <summary>
    /// Genera un vector aleatorio en 3D
    /// </summary>
    /// <returns>Fuerza aleatoria para arriba</returns>
    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minForce, maxForce);
    }
    
    /// <summary>
    /// Genera un número aleatorio 
    /// </summary>
    /// <returns>Valor aleatorio entre -maxtorque y maxtorque</returns>
    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    
    /// <summary>
    /// Genera una posición aleatoria
    /// </summary>
    /// <returns>Posición aleatoria 3Dm con la cordenada z = 0</returns>
    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange),ySpawnPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
