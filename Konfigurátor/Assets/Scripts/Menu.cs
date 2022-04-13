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
        [SerializeField] int i = 0;

        void Start()
        {
            if(body != null)
            {
                ChangeColor();
            }
            if(objects.Length > 0)
            {
                Change();
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