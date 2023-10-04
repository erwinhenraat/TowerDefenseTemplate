using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class UpdateFragAmt : MonoBehaviour
{
    public TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
    }

    void Update()
    {
        string HolderName = gameObject.name;
        

        switch (HolderName)
        {
            case "fragmentAmount":
                textField.text = GlobalData.PlayerPoint.ToString();
                break;
            case "CCAmount":
                textField.text = GlobalData.CloudCoins.ToString();
                break;
        }
        
    }
}
