using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        if(level == 0)
        {
            this.transform.position = Vector3.zero;
        }
        if (level == 2)
        {
            this.transform.position = GameObject.Find("deur_02").transform.position;
            GameObject.Find("Main Camera").transform.position = GameObject.Find("deur_02").transform.position;
            GameObject.Find("Main Camera").GetComponent<FollowPlayer>().player = this.gameObject;
        }
        
    }
}
