using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Save : MonoBehaviour
    {
        public Data data;
        public Main main;

        public void SaveJSON(InputField file)
        {
            string json = JsonUtility.ToJson(data);
            WriteData($"{file.text}.txt", json);
            file.text = "";
            main.saveButtons[0].SetActive(true);
            main.saveButtons[1].SetActive(false);
            main.saveButtons[2].SetActive(false);
        }
        public void LoadJSON(InputField file)
        {
            string json = ReadFile($"{file.text}.txt");
            JsonUtility.FromJsonOverwrite(json, data);
            Apply(0, data.tires);
            Apply(1, data.spoilers);
            Apply(2, data.roofScoops);
            Apply(3, data.rims);
            Apply(4, data.exhausts);
            Apply(5, data.colors);
            main.Start();
            file.text = "";
            main.saveButtons[3].SetActive(true);
            main.saveButtons[4].SetActive(false);
            main.saveButtons[5].SetActive(false);
        }
        void Apply(int a, int e)
        {
            main.menu[a].i = e;
        }
        void WriteData(string name, string json)
        {
            string path = GetPath(name);
            Debug.Log(path);
            FileStream fileStream = new FileStream(path, FileMode.Create);

            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(json);
            }
        }
        string ReadFile(string name)
        {
            string path = GetPath(name);
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            }
            return "";
        }
        string GetPath(string name)
        {
            return Application.persistentDataPath + "/" + name;
        }
    }
}
