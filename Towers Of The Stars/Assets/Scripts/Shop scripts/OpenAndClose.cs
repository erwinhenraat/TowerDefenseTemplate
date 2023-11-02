using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpenAndClose : MonoBehaviour
{

    public GameObject shop;
    public GameObject upgrades;
    public CanvasGroup group;
    public UpgradeTower upgrader;
    public void Start()
    {
        
    }

    public void OnClick()
    {
        string button = gameObject.name;

        switch (button)
        {
            case "ExitButton":
                Debug.Log("ShopClosed");
                HideShop();
                HideUpgrades();
                return;
            case "OpenButton":
                Debug.Log("ShopOpened");
                ShowShop();
                return;
        }
    }

    public void ShowShop()
    {
        group = shop.GetComponent<CanvasGroup>();
        group.alpha = 1f;
        group.blocksRaycasts = true;
        upgrader.HookTower();

    }
    public void HideShop()
    {
        group = shop.GetComponent<CanvasGroup>();
        group.alpha = 0f;
        group.blocksRaycasts = false;
    }
    public void HideUpgrades()
    {
        upgrades = GameObject.Find("UpgradeItemHolder");
        group = upgrades.GetComponent<CanvasGroup>();
        group.alpha = 0f;
        group.blocksRaycasts = false;
    }

}
