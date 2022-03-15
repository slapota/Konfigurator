using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Spoilers : MonoBehaviour
    {
        public GameObject[] panels, spoilers;
        public SimpleScrollSnap sss;
        int i;

        void Start()
        {
            spoilers[i].SetActive(true);
            sss = sss.GetComponent<SimpleScrollSnap>();
            foreach (var item in panels)
            {
                sss.Add(item, sss.Content.childCount);
            }
        }
        public void ChangeSpoiler()
        {
            for (int o = 0; o < spoilers.Length; o++)
            {
                spoilers[o].SetActive(false);
            }
            spoilers[i].SetActive(true);
        }
        public void Next()
        {
            i++;
            if (i < 0)
            {
                i = spoilers.Length - 1;
            }
            else if (i > spoilers.Length - 1)
            {
                i = 0;
            }
        }
        public void Previous()
        {
            i--;
            if (i < 0)
            {
                i = spoilers.Length - 1;
            }
            else if (i > spoilers.Length - 1)
            {
                i = 0;
            }
        }
    }

}