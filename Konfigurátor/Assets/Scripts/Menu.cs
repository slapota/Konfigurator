using System;
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
        public Data data;
        public int i = 0;

        void Start()
        {
            ScrollSnap = ScrollSnap.GetComponent<SimpleScrollSnap>();
            foreach (var item in panels)
            {
                ScrollSnap.Add(item, ScrollSnap.Content.childCount);
            }
        }
        public void Change(int a)
        {
            foreach (var item in objects)
            {
                item.SetActive(false);
            }
            objects[i].SetActive(true);
            switch (a)
            {
                case 0:
                    data.exhausts = i;
                    break;
                case 1:
                    data.roofScoops = i;
                    break;
                case 2:
                    data.spoilers = i;
                    break;
                case 3:
                    data.rims = i;
                    break;
                case 4:
                    data.tires = i;
                    break;
            }
        }
        public void ChangeColor()
        {
            body.color = panels[i].GetComponent<Image>().color;
            data.colors = i;
        }
        public void Next()
        {
            i++;
            Clamp();
        }
        public void Previous()
        {
            i--;
            Clamp();
        }
        void Clamp()
        {
            i = (int)Mathf.Repeat(i, panels.Length);
        }
    }
}