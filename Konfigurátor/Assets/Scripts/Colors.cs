using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Colors : MonoBehaviour
    {
        public GameObject[] materials;
        public Material body;
        public SimpleScrollSnap sss;
        public GameObject main, canvas;
        int i = 0;

        void Start()
        {
            body.color = materials[0].GetComponent<Image>().color;
            sss = sss.GetComponent<SimpleScrollSnap>();
            foreach(var i in materials)
            {
                sss.Add(i, sss.Content.childCount);
            }
        }
        public void Back()
        {
            canvas.SetActive(false);
            main.SetActive(true);
        }
        public void ColorMenu()
        {
            canvas.SetActive(true);
            main.SetActive(false);
        }
        public void ChangeColor()
        {
            body.color = materials[i].GetComponent<Image>().color;
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