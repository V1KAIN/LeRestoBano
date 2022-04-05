using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MMButtonScript : MonoBehaviour
{
    private EventSystem _eventSystem;

    private void Start()
    {
        _eventSystem = EventSystem.current;
    }

    private void Update()
    {
        if (_eventSystem.currentSelectedGameObject == gameObject)
        {
            LeanTween.scale(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().localScale*1.25f, 1f).setDelay(1f);
        }
    }
}
