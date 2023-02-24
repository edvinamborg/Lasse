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
        //Uppgift_1D();
        //Uppgift_2A();
        //Uppgift_2B();
        //Uppgift_3A();
        //Uppgift_3B();
        //Uppgift_4A();
        //Uppgift_4C();
        //Uppgift_5();
        //Uppgift_6();
        Uppgift_7A();

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

    private void Uppgift_1D()
    {
     
        double två = randomGenerator.Next(1, 7);
        double ett = randomGenerator.Next(1, 7);
        double summa;
        summa = ett + två;
        Debug.Log("nummrena är  " + ett + " och " + två + " summan är " + summa);
    }

    private void Uppgift_2A()
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

    private void Uppgift_2B()
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

     private void Uppgift_3A()
     {
        int räknare = 1;
        while (räknare < 6)
        {
            Debug.Log("" + räknare);
            räknare = räknare + 1;
        }
     }

    private void Uppgift_3B()
    {
        int räknare = 5;
        while (räknare < 21)
        {
            Debug.Log("" + räknare);
            räknare = räknare + 3;
        }
    }


    private void Uppgift_4A()
    {
        for (int räknare = 1; räknare < 6; räknare = räknare + 1)
        {
            Debug.Log("" + räknare);
        }
    }


    private void Uppgift_4C()
    {
        for (int räknare = 11; räknare > 0; räknare = räknare - 1, Debug.Log("" + räknare));
    }



    private void Uppgift_5()
    {
        int räknare = 1;
        
        while (räknare != 6)
        {
            räknare = randomGenerator.Next(1, 7);
            if (räknare !=6)
            {
                Debug.Log(räknare + ", slår igen");
            }
            else if (räknare == 6)
            {
                Debug.Log(räknare + "Nu är du klar");
            }
        }
        
    }

    private void Uppgift_6()
    {
        int tärning1 = randomGenerator.Next(1, 7);
        int tärning2 = randomGenerator.Next(1, 7);
        Debug.Log(tärning1 +" "+ tärning2);
        if (tärning1 == tärning2)
        {
            if (tärning1 == 6)
            {
                Debug.Log("Storvinst");
            }
            else
            {
                Debug.Log("Liten vinst");
            }
        }
        else
        {
            Debug.Log("Förlust");
        }
    }


    private void Uppgift_7A()
    {
        int[] lista = {3, 5, 7, 9, 11, 13};
       int output = "";
       foreach (int nummer in lista)
       {
        output += (nummer + ", ");
       }
       Debug.Log(output);
    }





}


