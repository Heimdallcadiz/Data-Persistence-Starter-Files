using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Name");

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        
    }
}
