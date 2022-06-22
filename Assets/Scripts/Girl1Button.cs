using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl1Button : MonoBehaviour
{
    public GameObject LoveCanvas;
    public GameObject GirlCanvas;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject ActiveHeart1;
    public GameObject ActiveHeart2;
    public GameObject ActiveHeart3;
    public GameObject ActiveHeart4;
    public GameObject ActiveHeart5;
    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public GameObject Talk4;
    public GameObject FakeHeart1;
    public GameObject FakeHeart2;
    public GameObject Character;

    public void onclick()
    {
        GirlCanvas.SetActive(true);
        LoveCanvas.SetActive(false);
        heart1.SetActive(false);
        heart2.SetActive(false);
        heart3.SetActive(false);
        heart4.SetActive(false);
        heart5.SetActive(false);
        Talk1.SetActive(false);
        Talk2.SetActive(false);
        Talk3.SetActive(false);
        Talk4.SetActive(false);
        FakeHeart1.SetActive(false);
        FakeHeart2.SetActive(false);
        Character.SetActive(true);
        if (ActiveHeart1.activeInHierarchy == true)
        {
            heart1.SetActive(true);
            Talk1.SetActive(true);
        }
        if (ActiveHeart2.activeInHierarchy == true)
        {
            heart2.SetActive(true);
            Talk2.SetActive(true);
        }
        if (ActiveHeart3.activeInHierarchy == true)
        {
            heart3.SetActive(true);
            Talk3.SetActive(true);
        }
        if (ActiveHeart4.activeInHierarchy == true)
        {
            heart4.SetActive(true);
            Talk4.SetActive(true);
        }
        if (ActiveHeart5.activeInHierarchy == true)
        {
            heart5.SetActive(true);
        }
    }
}
