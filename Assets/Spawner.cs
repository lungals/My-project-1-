using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject inimigo;
    [SerializeField] float Size;
    float checkArea;
    [SerializeField] float intervaloInicial;
    [SerializeField] float intervalo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", intervaloInicial, intervalo);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void Spawn()
    {
        float initialPosition = transform.position.x - (Size / 2);
        float finalPosition = transform.position.x + (Size / 2);
        checkArea = Random.Range(initialPosition, finalPosition);
        float size = Random.Range(0.2f, 0.6f);
        inimigo.transform.localScale = new Vector2(size, size);
        Instantiate(inimigo, new Vector3(checkArea, transform.position.y, 0), Quaternion.identity);
        Debug.Log("limite: " + checkArea);


    }
}
