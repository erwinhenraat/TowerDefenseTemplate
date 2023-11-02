using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BuyTower : MonoBehaviour
{
    public GameObject boughtTower;
    public Vector2 mousePos;
    public UpdateShopUI ShopUI;
    public GameObject shop;

    private void Start()
    {
        GlobalData.TowerList.ToArray();
    }

    public void OnClick()
    {
        OpenAndClose HideFunction = GameObject.Find("OpenButton").GetComponent<OpenAndClose>();

        

        if (GlobalData.CloudCoins >= ShopUI.TowerCost)
        {
            GameObject spawnedTower = Instantiate(boughtTower, transform.position, Quaternion.identity);
            GlobalData.TowerList.Add(spawnedTower);
            HideFunction.HideShop();
        }
    }
}


