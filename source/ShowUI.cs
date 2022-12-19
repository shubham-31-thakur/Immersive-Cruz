using System.Collections;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System.Collections.Generic;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using UnityEngine;

public class ShowUI : MonoBehaviour
{

    public GameObject uiObject;
#pragma warning disable IDE0040 // Add accessibility modifiers
    void Start()
#pragma warning restore IDE0040 // Add accessibility modifiers
    {
        uiObject.SetActive(false);
    }
    // Update is called once per frame
#pragma warning disable IDE0040 // Add accessibility modifiers
    void OnTriggerEnter(Collider player)
#pragma warning restore IDE0040 // Add accessibility modifiers
    {
#pragma warning disable UNT0002 // Inefficient tag comparison
        if (player.gameObject.tag == "Player")
#pragma warning restore UNT0002 // Inefficient tag comparison
        {
            uiObject.SetActive(true);
#pragma warning disable UNT0016 // Unsafe way to get the method name
            StartCoroutine("WaitForSec");
#pragma warning restore UNT0016 // Unsafe way to get the method name
        }
    }
#pragma warning disable IDE0040 // Add accessibility modifiers
    IEnumerator WaitForSec()
#pragma warning restore IDE0040 // Add accessibility modifiers
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        //Destroy(gameObject);
    }

}