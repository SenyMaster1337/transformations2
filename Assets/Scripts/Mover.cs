using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0, 0, 0.05f);
    }
}
