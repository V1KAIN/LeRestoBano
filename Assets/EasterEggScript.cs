using System;
using UnityEngine;

public class EasterEggScript : MonoBehaviour
{
    [SerializeField] private float animationTime; 
    
    private void Update()
    {
        animationTime -= Time.deltaTime;

        if (animationTime <= 0) { SkipAnimation();}
        if (Input.GetButtonDown("Fire1")) { SkipAnimation();}
    }

    void SkipAnimation()
    {
        MainMenuManager.LoadSceneAtIndex(0);        
    }
}
