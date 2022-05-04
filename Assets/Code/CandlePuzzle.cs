using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlePuzzle : MonoBehaviour
{
    public GameObject testCube;

    public GameObject candle1;
    public GameObject candle2;
    public GameObject candle3;
    public GameObject candle4;
    public GameObject candle5;
    public GameObject candle6;

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;

    bool cl1 = false;
    bool cl2 = false;
    bool cl3 = false;
    bool cl4 = false;
    bool cl5 = false;
    bool cl6 = false;

    public string correctAnswer = "123456";
    string currentOrder = "";



    string result;

    private void OnTriggerEnter(Collider other)
    {
        if (PublicVars.haveLightingCandle)
        {
            Debug.Log(other.tag);
            // verify syntax
            
            switch (other.tag)
            {
                case "Candle6":
                    if (!cl6)
                    {
                        currentOrder += "6";
                        candle6.SetActive(true);
                        light6.SetActive(true);
                        cl6 = true;
                        CheckResult();
                    }
                    
                    break;

                case "Candle5":

                    if (!cl5) 
                    {
                        currentOrder += "5";
                        candle5.SetActive(true);
                        light5.SetActive(true);
                        cl5 = true;
                        CheckResult();
                    }

                    break;

                case "Candle4":
                    if (!cl4) 
                    {
                        currentOrder += "4";
                        candle4.SetActive(true);
                        light4.SetActive(true);
                        cl4 = true;
                        CheckResult();
                    }
                    
                    break;

                case "Candle3":

                    if (!cl3) 
                    {
                        currentOrder += "3";
                        candle3.SetActive(true);
                        light3.SetActive(true);
                        cl3 = true;
                        CheckResult();
                    }
                    
                    break;

                case "Candle2":

                    if (!cl2) 
                    {
                        currentOrder += "2";
                        candle2.SetActive(true);
                        light2.SetActive(true);
                        cl2 = true;
                        CheckResult();
                    }
                    
                    break;

                case "Candle1":

                    if (!cl1) 
                    {
                        currentOrder += "1";
                        candle1.SetActive(true);
                        light1.SetActive(true);
                        cl1 = true;
                        CheckResult();
                    }
                                    
                    break;
            }
            
        }
    }

    void CheckResult() 
    {
        if (currentOrder.Length == correctAnswer.Length) 
        {
            if (currentOrder.Equals(correctAnswer))
            {
                testCube.SetActive(true);
            }
            else 
            {
                candle6.SetActive(false);
                light6.SetActive(false);
                cl6 = false;

                candle5.SetActive(false);
                light5.SetActive(false);
                cl5 = false;

                candle4.SetActive(false);
                light4.SetActive(false);
                cl4 = false;

                candle3.SetActive(false);
                light3.SetActive(false);
                cl3 = false;

                candle2.SetActive(false);
                light2.SetActive(false);
                cl2 = false;

                candle1.SetActive(false);
                light1.SetActive(false);
                cl1 = false;

                currentOrder = "";
            }
        }
    }

    void Update()
    {
       

    }
}
