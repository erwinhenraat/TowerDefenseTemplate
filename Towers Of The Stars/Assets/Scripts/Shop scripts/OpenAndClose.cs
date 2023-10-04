using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpenAndClose : MonoBehaviour
{

    public GameObject shop;
    public void Start()
    {
        Debug.Log(shop.transform.position);

        
    }

    public void OnClick()
    {
        string button = gameObject.name;

        switch (button)
        {
            case "ExitButton":
                Debug.Log("ShopClosed");
                shop.transform.position = new Vector3(18.93f, 0f, 9.00f);
                return;
            case "OpenButton":
                Debug.Log("ShopOpened");
                shop.transform.position = new Vector3(6.55f, 0f, 87.0f);
                return;
        }
    }

}
