using System;
using System.Collections;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PopUpTextScript : MonoBehaviour
{
    [Header("Drag & Drop")]
    [SerializeField] private GameObject textPrefab;
    [SerializeField] private AnimationClip textAnimation;
    
    [Header("Parameters")]
    [SerializeField] private float spawnHeight;

    //Privates
    private float timeToDisappear;
    
    private void Start()
    {
        timeToDisappear = textAnimation.length;
    }
    public void SpawnText(string objectName)
    {
        Vector3 spawnPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + spawnHeight, gameObject.transform.position.z);
        
        GameObject textObject = Instantiate(textPrefab, spawnPos, quaternion.identity);
        textObject.GetComponentInChildren<TextMeshPro>().text = "+1 " + objectName;

        StartCoroutine(DestroyText(textObject));
    }

    IEnumerator DestroyText(GameObject textObject)
    {
        yield return new WaitForSeconds(timeToDisappear);
        Destroy(textObject);
    }
}
