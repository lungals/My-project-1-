using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
            if (transform.position.y < 4.37)
            {
                transform.position += new Vector3(0, 0, 0);
            };
        if (Input.GetKey(KeyCode.S))
            if (transform.position.y > -4.29)
            {
                transform.position += new Vector3(0, 0, 0);
            };
        if (Input.GetKey(KeyCode.A))
            if (transform.position.x > -8.35)
            {
                transform.position += new Vector3(0, 0, 0);
            };
        if (Input.GetKey(KeyCode.D))
            if (transform.position.x < 8.49)
            {
                transform.position += new Vector3(0, 0, 0);
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
