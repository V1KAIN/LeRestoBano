using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScript : MonoBehaviour
{
    [SerializeField] private AnimationClip creditsAnimationClip;

    private float AnimTimeLeft = 0;
    private void Start()
    {
        AnimTimeLeft = creditsAnimationClip.length;
    }

    private void Update()
    {
        AnimTimeLeft -= Time.deltaTime;

        if (AnimTimeLeft <= 0)
        {
            MainMenuManager.LoadSceneAtIndex(0);
        }
    }
}
