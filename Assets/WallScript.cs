using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collide");
    }
}
