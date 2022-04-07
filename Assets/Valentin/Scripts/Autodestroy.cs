using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    public void DestroyThis()
    {
        Destroy(gameObject);
    }
}
