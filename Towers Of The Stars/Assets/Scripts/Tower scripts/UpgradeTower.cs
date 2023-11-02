using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class UpgradeTower : MonoBehaviour
{
    public int UpgradeCost = 5;
    public TMP_Text textfield;
    public TowerStats towerStats;
    public string buttonName;
    TMP_Text UpgradeCostText;

    private void Start()
    {
        textfield = transform.GetChild(0).GetComponent<TMP_Text>();
        buttonName = gameObject.name;
        UpgradeCostText = transform.GetChild(2).GetComponent<TMP_Text>();
    }

    private void Update()
    {
        //if (towerStats != null && buttonName == "UpgradeButton") textfield.text = $"Damage = {towerStats.damage}";

        if (towerStats != null)
        {
            switch (buttonName)
            {
                case "UpgradeButton":
                    textfield.text = $"damage = {towerStats.damage}";
                    UpgradeCostText.text = UpgradeCost.ToString();
                    return;
                case "DelayUpgrade":
                    textfield.text = $"Current speed = {towerStats.projSpeed}";
                    UpgradeCostText.text = UpgradeCost.ToString();
                    return;
            }
        }
    }

    public void UpgradeDamage()
    {
        if(GlobalData.CloudCoins >= UpgradeCost)
        {
            HookTower();
            towerStats.damage += 1;
            GlobalData.CloudCoins -= UpgradeCost;
            UpgradeCost += 2;
        }   
    }

    public void UpgradeSpeed()
    {
        if(GlobalData.CloudCoins >= UpgradeCost)
        {
            HookTower();
            Debug.Log(towerStats.firingSpeed);
            towerStats.projSpeed += 0.5f;
            GlobalData.CloudCoins -= UpgradeCost;
            UpgradeCost += 2;
        }
    }

    public void HookTower()
    {
        if (GlobalData.SelectedTower != null) towerStats = GlobalData.SelectedTower.GetComponent<TowerStats>();
    }
}
