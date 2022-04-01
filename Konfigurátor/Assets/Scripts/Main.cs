using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject[] windows;

    void Start()
    {
        foreach (var item in windows)
        {
            item.SetActive(false);
        }
        windows.Single((x) => x.name == "MainMenu").SetActive(true);
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
        menu.LeanMove(new Vector2(menu.transform.position.x, menu.transform.position.y - 500), 0.5f).setEaseInQuart();
        yield return new WaitForSeconds(0.6f);
        menu.gameObject.SetActive(false);
        menu.position = pos;
        windows.Single((x) => x == name).SetActive(true);
    }
}
