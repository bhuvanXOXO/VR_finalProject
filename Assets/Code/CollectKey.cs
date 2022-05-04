using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public GameObject floor2Barrier;
    public AudioSource collectKey;
    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Key")){
             collectKey.Play();
             PublicVars.haveKey = true;
             Destroy(other.gameObject);  
             floor2Barrier.SetActive(false);  
         }
    }
}
