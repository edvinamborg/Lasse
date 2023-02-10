using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sulotions : MonoBehaviour
{
System.Random randomGenerator = new System.Random();

    public void Start()
    {
        
        //Uppgift_1A();
        //Uppgift_1B();
        //Uppgift_1C();
        //Uppgift_1D();
        //Uppgift_1E();
        //Uppgift_1F();
        //Uppgift_1G();
        Uppgift_1H();
    }

    private void Uppgift_1A()
    {
        //Debug.Log("Hello");
    }
    private void Uppgift_1B()
    {

        double höjd = 5.4;
        double bredd = 9.6;
        double area;
        area = (bredd * höjd)/2;
        Debug.Log("Rektangeln har höjden:" + höjd +  " bredden:" + bredd + " och arean" + area);

    }

    private void Uppgift_1C()
    {
     
        double två = randomGenerator.Next(1, 7);
        double ett = randomGenerator.Next(1, 7);
        double summa;
        summa = ett + två;
        Debug.Log("nummrena är  " + ett + " och " + två + " summan är " + summa);
    }

    private void Uppgift_1D()
    {
        double tärningsögon = randomGenerator.Next(1, 7);
        Debug.Log("Tärningen visar " + tärningsögon);
        String output = "test ";
        if (tärningsögon == 1)
        {
            output += "Minsta talet";
        }
        else
        {
            output += "2-6";
        }
        Debug.Log(output);
    }

    private void Uppgift_1E()
    {
        double tärningsögon1 = randomGenerator.Next(1, 7);
        double tärningsögon2 = randomGenerator.Next(1, 7);
        Debug.Log("Första kastet visade " + tärningsögon1);
        Debug.Log("Andra kastet visade " + tärningsögon2);
        string output = "";
        if (tärningsögon1 == tärningsögon2)
        {
            output += "Vinst!";
        }
        else
        {
            output += "Förlust";
        }
        Debug.Log(output);
    }

     private void Uppgift_1F()
     {
        int räknare = 1;
        while (räknare < 6)
        {
            Debug.Log("" + räknare);
            räknare = räknare + 1;
        }
     }

    private void Uppgift_1G()
    {
        int räknare = 5;
        while (räknare < 21)
        {
            Debug.Log("" + räknare);
            räknare = räknare + 3;
        }
    }


    private void Uppgift_1H()
    {
        for (int räknare = 1; räknare < 6; räknare = räknare + 1)
        {
            Debug.Log("" + räknare);
        }
    }




}


