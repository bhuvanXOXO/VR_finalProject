using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CandyCode : MonoBehaviour
{
    public TextMeshProUGUI candyUI;
    public AudioSource crunchCandy;
    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Player")){
             crunchCandy.Play();
             PublicVars.candyNum++;
             candyUI.text = PublicVars.candyNum++.ToString();
             Destroy(gameObject);
         }
    }
}
