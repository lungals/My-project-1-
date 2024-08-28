using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float spawnInterval = 3f; // Intervalo de spawn em segundos
    private Vector3 initialPosition;
    private Rigidbody2D rb;


    private void Start()
    {
        // Inicializa o Rigidbody2D
        rb = GetComponent<Rigidbody2D>();

        // Define a posição inicial do asteroide
        initialPosition = transform.position;

        // Se você deseja que o asteroide retorne à posição do topo da tela onde está a nave,
        // você pode ajustar a initialPosition para a posição da nave ou o topo da tela
    }

    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("teleport"))
        {
            // Mova o asteroide para a posição inicial (ou uma posição específica no topo da tela)
            transform.position = initialPosition;

            // Zere a velocidade do asteroide
            if (rb != null)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }

    // Você pode adicionar uma função de spawn para criar asteroides conforme o intervalo
    private IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            // Instancia um novo asteroide aqui se necessário
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
