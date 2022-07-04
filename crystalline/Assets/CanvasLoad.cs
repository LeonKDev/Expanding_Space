using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<CanvasLoad>().Length; i++)
        {
            if (Object.FindObjectsOfType<CanvasLoad>()[i] != this)
            {
                if (Object.FindObjectsOfType<CanvasLoad>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }

        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
