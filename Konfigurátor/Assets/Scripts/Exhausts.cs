using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Exhausts : MonoBehaviour
    {
        public GameObject[] panels, exhausts;
        public SimpleScrollSnap sss;
        int i;

        void Start()
        {
            exhausts[i].SetActive(true);
            sss = sss.GetComponent<SimpleScrollSnap>();
            foreach (var item in panels)
            {
                sss.Add(item, sss.Content.childCount);
            }
        }
        public void ChangeExhaust()
        {
            for (int o = 0; o < exhausts.Length; o++)
            {
                exhausts[o].SetActive(false);
            }
            exhausts[i].SetActive(true);
        }
        public void Next()
        {
            i++;
            if (i < 0)
            {
                i = exhausts.Length - 1;
            }
            else if (i > exhausts.Length - 1)
            {
                i = 0;
            }
        }
        public void Previous()
        {
            i--;
            if (i < 0)
            {
                i = exhausts.Length - 1;
            }
            else if (i > exhausts.Length - 1)
            {
                i = 0;
            }
        }
    }

}