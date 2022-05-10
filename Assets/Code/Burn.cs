using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour
{

    public GameObject BigFire;


    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PublicVars.haveTorch) 
            {
                Explode();
                Destroy(gameObject);
            }
            

            

        }
    }
    void Explode()
    {
        Vector3 position = new Vector3(BigFire.transform.position.x, BigFire.transform.position.y, BigFire.transform.position.z);
        GameObject firework = Instantiate(BigFire, position, Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();
    }
}