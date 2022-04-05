using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Management : MonoBehaviour
{
    // Start is called before the first frame update
    public bool InvisibleAtStart;
    private Collider collider;
    public GameObject NextUI;
    public bool ClickAgainToCloseNextUI;
    private int NextUIOpen;

    private void Awake()
    {
        if (InvisibleAtStart)
        {
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        collider = GetComponent<Collider>();
    }

    private void Update()
    {
        if (NextUIOpen > 0)
        {
            if (NextUI.gameObject.activeSelf == false)
            {
                NextUIOpen--;
                collider.enabled = true;
            }
        }
    }

    private void OnMouseDown()
    {
        if(NextUI != null)
        {
            if(ClickAgainToCloseNextUI != true)
            {
                collider.enabled = false;
                NextUI.SetActive(true);
                NextUIOpen++;
            }
            else
            {
                switch (NextUIOpen)
                {
                    case 0:
                        NextUI.SetActive(true);
                        NextUIOpen++;
                        break;
                    case 1:
                        NextUI.SetActive(false);
                        NextUIOpen--;
                        break;
                }
            }
        }
    }

    public void ForceDesactive()
    {
        NextUIOpen = 0;
        NextUI.SetActive(false);
    }
}
