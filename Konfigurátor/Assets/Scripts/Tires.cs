using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Tires : MonoBehaviour
    {
        public GameObject[] panels, tires;
        public Material[] materials;
        public SimpleScrollSnap sss;
        public GameObject main, tireMenu, canvas;
        int i = 0;

        void Start()
        {
            main.SetActive(true);
            canvas.SetActive(false);
            tireMenu.SetActive(false);
            for (int o = 0; o < tires.Length; o++)
            {
                tires[o].GetComponent<MeshRenderer>().material = materials[0];
            }
            sss = sss.GetComponent<SimpleScrollSnap>();
            /*foreach (var i in materials)
            {
                sss.Add(i, sss.Content.childCount);
            }*/
        }
        public void Menu()
        {
            main.SetActive(true);
            tireMenu.SetActive(false);
        }
        public void TireMenu()
        {
            tireMenu.SetActive(false);
            canvas.SetActive(true);
        }
        public void TiresMenu()
        {
            tireMenu.SetActive(true);
            main.SetActive(false);
            canvas.SetActive(false);
        }
        public void ChangeTires()
        {
            for (int o = 0; o < tires.Length; o++)
            {
                tires[o].GetComponent<MeshRenderer>().material = materials[i];
            }
        }
        public void Next()
        {
            i++;
            if (i < 0)
            {
                i = materials.Length - 1;
            }
            else if (i > materials.Length - 1)
            {
                i = 0;
            }
        }
        public void Previous()
        {
            i--;
            if (i < 0)
            {
                i = materials.Length - 1;
            }
            else if (i > materials.Length - 1)
            {
                i = 0;
            }
        }
    }

}
