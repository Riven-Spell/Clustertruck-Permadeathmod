using System;
using UnityEngine;

namespace Mod
{
    public class Main : MonoBehaviour
    {
        public void Start()
        {
            var modObject = new GameObject();
            modObject.AddComponent<modComponent>();
            DontDestroyOnLoad(modObject);
        }
    }


    public class modComponent : MonoBehaviour
    {
        GameManager gm;
        Manager m;
        public void Start() {
            gm = FindObjectOfType<GameManager>();
            m = FindObjectOfType<Manager>();
        }

        public void Update() {
            if (GameManager.mapDeaths != 0)
            {
                m.Play(true);
                GameManager.mapDeaths = 0;
            }
            if(TesseractModLoader.)
        }
    }
}