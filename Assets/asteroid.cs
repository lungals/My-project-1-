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

        // Define a posi��o inicial do asteroide
        initialPosition = transform.position;

        // Se voc� deseja que o asteroide retorne � posi��o do topo da tela onde est� a nave,
        // voc� pode ajustar a initialPosition para a posi��o da nave ou o topo da tela
    }

    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("teleport"))
        {
            // Mova o asteroide para a posi��o inicial (ou uma posi��o espec�fica no topo da tela)
            transform.position = initialPosition;

            // Zere a velocidade do asteroide
            if (rb != null)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }

    // Voc� pode adicionar uma fun��o de spawn para criar asteroides conforme o intervalo
    private IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            // Instancia um novo asteroide aqui se necess�rio
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
