using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class Door3 : MonoBehaviour
{
    public bool IsInRange;


    void Start()
    {

    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }




    void Update()
    {
        if (IsInRange)


        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(4);
            }



            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene(3);
            }
        }





    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            Debug.Log("Player is now in Range");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        IsInRange = false;
        Debug.Log("Player is now in Range");
    }
}
