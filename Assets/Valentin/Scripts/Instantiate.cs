using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Ui;

    public void OnClick()
    {
        GameObject go = Instantiate(Ui,transform);
        //go.transform.SetParent(gameObject.transform);
    }
}
