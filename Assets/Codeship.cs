using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rdb;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, -7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            if (transform.position.y < 4.16)
            {
                
            };
        if (Input.GetKey(KeyCode.S))
            if (transform.position.y > -4.21)
            {
                
            };
        if (Input.GetKey(KeyCode.A))
            if (transform.position.x > -7.99)
            {
                
            };
        if (Input.GetKey(KeyCode.D))
            if (transform.position.x < 8)
            {
            
            }
           


    }
    //FixedUpdate é chamado a cada frame, mas é chamado com um tempo fixo
    private void FixedUpdate()
    {
        Movimentos();
    }
    /// <summary>
    /// funcao que movimenta
    /// </summary>
    void Movimentos()
    {
        /* if (Input.GetKey(KeyCode.D)) //se aperta a tecla D
         {
             rdb.AddForce(Vector2.right * 10); //adiciona força para a direita
         }
         if (Input.GetKey(KeyCode.A))
         {
             rdb.AddForce(Vector2.left * 10);
         }
         if (Input.GetKey(KeyCode.W))
         {
             rdb.AddForce(Vector2.up * 10);
         }
         if (Input.GetKey(KeyCode.S))
         {
             rdb.AddForce(Vector2.down * 10);*/
        // }
        if (Input.GetKey(KeyCode.W))
        {
            rdb.AddRelativeForce(Vector2.up * Speed);
            if (Speed <= 5)
                Speed += 0.6f;
        }
        else
        {
            if (Speed <= 0)
                Speed = 0;
            else
                Speed -= 0.9f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 0, -200) * Time.deltaTime;
        };
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, 0, 200) * Time.deltaTime;
        };
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject); // Destrói o inimigo
        }
    }
}