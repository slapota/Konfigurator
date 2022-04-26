using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Main : MonoBehaviour
    {
        public GameObject[] windows;
        public GameObject[] saveButtons;
        public Menu[] menu;

        public void Start()
        {
            for (int i = 0; i < menu.Length; i++)
            {
                if (menu[i].body != null)
                {
                    menu[i].ChangeColor();
                }
                else
                {
                    menu[i].Change(i);
                }
            }
            foreach (var item in windows)
            {
                item.SetActive(false);
            }
            windows.Single((x) => x.name == "MainMenu").SetActive(true);
        }
        public void Save_Load(int a)
        {
            saveButtons[a].SetActive(false);
            saveButtons[a + 1].SetActive(true);
            saveButtons[a + 2].SetActive(true);
        }
        public void Windows(GameObject name)
        {
            foreach (var item in windows)
            {
                if (item.activeInHierarchy)
                {
                    StartCoroutine(Close(item.transform, item.transform.position, name));
                }
            }
        }
        IEnumerator Close(Transform menu, Vector3 pos, GameObject name)
        {
            foreach (var item in menu.GetComponentsInChildren<Transform>())
            {
                item.LeanMove(new Vector2(item.position.x, item.position.y - 500), 0.5f).setEaseInQuart();
            }
            yield return new WaitForSeconds(0.6f);
            menu.gameObject.SetActive(false);
            menu.position = pos;
            windows.Single((x) => x == name).SetActive(true);
        }
    }

}