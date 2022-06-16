using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp : MonoBehaviour
{
    public bool pickedUp = false;
    public GameObject test;
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;
    [SerializeField] private Sprite sprite3;
    [SerializeField] private Sprite sprite4;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Item1" && pickedUp == false)
        {

            pickedUp = true;
            Debug.Log("touch1");
            Destroy(other.gameObject);
            test.GetComponent<Image>().sprite = sprite1;
        }

        if (other.gameObject.tag == "Item2" && pickedUp == false)
        {

            pickedUp = true;
            Debug.Log("touch2");
            Destroy(other.gameObject);
            test.GetComponent<Image>().sprite = sprite2;
        }
        
        if (other.gameObject.tag == "Item3" && pickedUp == false)
        {

            pickedUp = true;
            Debug.Log("touch3");
            Destroy(other.gameObject);
            test.GetComponent<Image>().sprite = sprite3;
        }
        if (other.gameObject.tag == "Item4" && pickedUp == false)
        {

            pickedUp = true;
            Debug.Log("touch4");
            Destroy(other.gameObject);
            test.GetComponent<Image>().sprite = sprite4;
        }

        if (pickedUp == true)
        {
            test.SetActive(true);
            
        }
        else if (pickedUp == false)
        {
            test.SetActive(false);
        }
    }

}
