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
        int i = 0;

        void Start()
        {
            for (int o = 0; o < tires.Length; o++)
            {
                tires[o].GetComponent<MeshRenderer>().material = materials[0];
            }
            sss = sss.GetComponent<SimpleScrollSnap>();
            foreach (var i in panels)
            {
                sss.Add(i, sss.Content.childCount);
            }
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
