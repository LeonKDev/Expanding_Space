using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class Deur : MonoBehaviour
{
    public bool IsInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    
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
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
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
