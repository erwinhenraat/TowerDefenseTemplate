using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class BuyTower : MonoBehaviour
{
    public GameObject boughtTower;
    public Vector2 mousePos;
    public UpdateShopUI ShopUI;
    public GameObject shop;

    public void OnClick()
    {
        if (GlobalData.CloudCoins >= ShopUI.TowerCost)
        {
            Instantiate(boughtTower, transform.position, Quaternion.identity);
            shop.transform.position = new Vector3(18.93f, 0f, 9.00f);
        }
    }
}


