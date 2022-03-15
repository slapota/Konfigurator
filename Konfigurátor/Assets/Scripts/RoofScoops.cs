using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class RoofScoops : MonoBehaviour
    {
        int i;
        public GameObject[] panels, roofscoops;
        public SimpleScrollSnap sss;

        void Start()
        {
            roofscoops[i].SetActive(true);
            sss = sss.GetComponent<SimpleScrollSnap>();
            foreach (var item in panels)
            {
                sss.Add(item, sss.Content.childCount);
            }
        }
        public void ChangeRoofScoop()
        {
            foreach (var item in roofscoops)
            {
                item.SetActive(false);
            }
            roofscoops[i].SetActive(true);
        }
        public void Next()
        {
            i++;
            if (i < 0)
            {
                i = roofscoops.Length - 1;
            }
            else if (i > roofscoops.Length - 1)
            {
                i = 0;
            }
        }
        public void Previous()
        {
            i--;
            if (i < 0)
            {
                i = roofscoops.Length - 1;
            }
            else if (i > roofscoops.Length - 1)
            {
                i = 0;
            }
        }
    }

}