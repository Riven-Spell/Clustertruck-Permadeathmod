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
        public void Start()
        {

        }

        public void Update()
        {
            if (GameManager.mapDeaths != 0)
            {
                FindObjectOfType<Manager>().NewGame();
                GameManager.mapDeaths = 0;
            }
        }

    }
}