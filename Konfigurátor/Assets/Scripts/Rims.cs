using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rims : MonoBehaviour
{
    public GameObject[] panels, rims;
    public GameObject canvas, main, tireMenu;

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
}
