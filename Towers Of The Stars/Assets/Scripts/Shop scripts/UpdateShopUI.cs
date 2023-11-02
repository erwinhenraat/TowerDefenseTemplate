using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class UpdateShopUI : MonoBehaviour
{
    public UpdateFragAmt GetField;
    public int TowerCost = 0;
    public int costIncrease;
    public BuyTower BuyScript;
    public TMP_Text TowerCostText;
    public void Start()
    {
        TowerCostText = transform.GetChild(2).GetComponent<TMP_Text>();
    }
    public void OnClick()
    {
        if (GlobalData.CloudCoins >= TowerCost)
        {
            BuyScript.OnClick();
            Debug.Log("Button Clicked!");
            GlobalData.CloudCoins -= TowerCost;
            TowerCost += costIncrease;

            GetField.textField.text = GlobalData.CloudCoins.ToString();
        }
        TowerCostText.text = TowerCost.ToString();
    }
}
