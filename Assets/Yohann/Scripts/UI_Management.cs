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
    public bool CloseMultipleUI;
    public GameObject[] MultipleUI;

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
            if(!ClickAgainToCloseNextUI)
            {
                collider.enabled = false;
                NextUI.SetActive(true);
                NextUIOpen++;
                if (CloseMultipleUI)
                {
                    for (int i = 0; i < MultipleUI.Length; i++)
                    {
                        MultipleUI[i].SetActive(true);
                    }
                }
            }
            else
            {
                switch (NextUIOpen)
                {
                    case 0:
                        if(!CloseMultipleUI)
                        {
                            NextUI.SetActive(true);
                            NextUIOpen++;
                        }
                        else
                        {
                            for (int i = 0; i < MultipleUI.Length; i++)
                            {
                                MultipleUI[i].SetActive(true);
                            }
                        }
                        break;
                    case 1:
                        if(!CloseMultipleUI)
                        {
                            NextUI.SetActive(false);
                            NextUIOpen--;
                        }
                        else
                        {
                            for (int i = 0; i < MultipleUI.Length; i++)
                            {
                                MultipleUI[i].SetActive(false);
                            }
                        }
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
