using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Menu : MonoBehaviour
    {
        public GameObject[] panels, objects;
        public SimpleScrollSnap ScrollSnap;
        public Material body;
        int i = 0;

        void Start()
        {
            if(body != null)
            {
                ChangeColor();
            }
            ScrollSnap = ScrollSnap.GetComponent<SimpleScrollSnap>();
            foreach (var item in panels)
            {
                ScrollSnap.Add(item, ScrollSnap.Content.childCount);
            }
        }
        public void Change()
        {
            foreach (var item in objects)
            {
                item.SetActive(false);
            }
            objects[i].SetActive(true);
        }
        public void ChangeColor()
        {
            body.color = panels[i].GetComponent<Image>().color;
        }
        public void Next()
        {
            i++;
            if (i < 0)
            {
                i = objects.Length - 1;
            }
            else if (i > objects.Length - 1)
            {
                i = 0;
            }
        }
        public void Previous()
        {
            i--;
            if (i < 0)
            {
                i = objects.Length - 1;
            }
            else if (i > objects.Length - 1)
            {
                i = 0;
            }
        }
    }
}