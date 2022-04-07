using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Ui;

    public void OnClick()
    {
        Instantiate(Ui );
    }
}
