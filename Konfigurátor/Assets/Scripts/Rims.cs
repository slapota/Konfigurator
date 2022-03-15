using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Rims : MonoBehaviour
    {
        public GameObject[] panels, prefabs;
        public SimpleScrollSnap sss;
        int i;

        void Start()
        {
            prefabs[i].SetActive(true);
            sss = sss.GetComponent<SimpleScrollSnap>();
            foreach (var item in panels)
            {
                sss.Add(item, sss.Content.childCount);
            }
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

}