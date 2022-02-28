using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rims : MonoBehaviour
{
    public GameObject[] panels, prefabs;
    public GameObject canvas, main, tireMenu;
    public int i;

    void Start()
    {
        canvas.SetActive(false);
        prefabs[i].SetActive(true);
    }
    public void RimMenu()
    {
        canvas.SetActive(true);
        tireMenu.SetActive(false);
    }
    public void TireMenu()
    {
        canvas.SetActive(false);
        main.SetActive(false);
        tireMenu.SetActive(true);
    }
    public void Menu()
    {
        main.SetActive(true);
        tireMenu.SetActive(false);
    }
    public void ChangeRims()
    {
        for (int o = 0; o < prefabs.Length; o++)
        {
            prefabs[o].SetActive(false);
        }
        prefabs[i].SetActive(true);
    }
    public void Next()
    {
        i++;
        if (i < 0)
        {
            i = prefabs.Length - 1;
        }
        else if (i > prefabs.Length - 1)
        {
            i = 0;
        }
    }
    public void Previous()
    {
        i--;
        if (i < 0)
        {
            i = prefabs.Length - 1;
        }
        else if (i > prefabs.Length - 1)
        {
            i = 0;
        }
    }
}
