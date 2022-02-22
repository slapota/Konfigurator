using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rims : MonoBehaviour
{
    public GameObject[] panels, rims, prefabs, instances;
    public GameObject canvas, main, tireMenu;
    int i;

    void Start()
    {
        canvas.SetActive(false);
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
        for (int o = 0; o < instances.Length; o++)
        {
            if(instances[o] != null)
            {
                Destroy(instances[o]);
            }
        }
        for (int o = 0; o < rims.Length; o++)
        {
            instances[o] = Instantiate(prefabs[o], rims[o].transform);
        }
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
