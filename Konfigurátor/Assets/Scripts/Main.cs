using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject[] windows;

    void Start()
    {
        foreach (var item in windows)
        {
            item.SetActive(false);
        }
        windows.Single((x) => x.name == "MainMenu").SetActive(true);
    }
    public void Windows(GameObject name)
    {
        foreach (var item in windows)
        {
            item.SetActive(false);
        }
        windows.Single((x) => x == name).SetActive(true);
    }
}
