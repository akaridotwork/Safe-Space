using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Keypad : MonoBehaviour
{
        public GameObject Knop1;
        public GameObject Knop2;
        public GameObject Knop3;
        public GameObject Knop4;


        public GameObject keypad;
        public GameObject player;
        public GameObject MainScreen;

    public GameObject doorClosed;




        




    public void fout()
    {
        Knop1.SetActive(false);
        Knop2.SetActive(false);
        Knop3.SetActive(false);
        Knop4.SetActive(false);

    }


    public void k1()
    {
        if (Knop1.activeInHierarchy == false)
        {
            Knop1.SetActive(true);
        }
        else
        {
            Knop1.SetActive(false);
            Knop2.SetActive(false);
            Knop3.SetActive(false);
            Knop4.SetActive(false);
        }
          
        
           
    }

    public void k2()
    {
        if(Knop1.activeInHierarchy == true && Knop2.activeInHierarchy == false)
        {
            Knop2.SetActive(true);
        }
        else
        {
            Knop1.SetActive(false);
            Knop2.SetActive(false);
            Knop3.SetActive(false);
            Knop4.SetActive(false);
        }
    }

    public void k3()
    {
        if (Knop1.activeInHierarchy == true && Knop2.activeInHierarchy == true && Knop3.activeInHierarchy == false) 
        {
            Knop3.SetActive(true);
        }
        else
        {
            Knop1.SetActive(false);
            Knop2.SetActive(false);
            Knop3.SetActive(false);
            Knop4.SetActive(false);
        }
    }

    public void k4()
    {
        if (Knop1.activeInHierarchy == true && Knop2.activeInHierarchy == true && Knop3.activeInHierarchy == true && Knop4.activeInHierarchy == false)
        {
            Knop4.SetActive(true);
        }
        else
        {
            Knop1.SetActive(false);
            Knop2.SetActive(false);
            Knop3.SetActive(false);
            Knop4.SetActive(false);
        }
    }

    public void Done()
    {
        if (Knop1.activeInHierarchy == true && Knop2.activeInHierarchy == true && Knop3.activeInHierarchy == true && Knop4.activeInHierarchy == true)
        {
            keypad.SetActive(false);
            player.SetActive(true);
            MainScreen.SetActive(true);
            doorClosed.SetActive(false);

        }
    }
}
