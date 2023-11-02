using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectOnClick : MonoBehaviour
{
    BoxCollider2D hitBox;
    public GameObject Shop, upgradeScreen;
    OpenAndClose OpenFunction;
    public CanvasGroup group;

    void Start()
    {
        hitBox = GetComponent<BoxCollider2D>();
        Shop = GameObject.Find("Shop");
        upgradeScreen = GameObject.Find("UpgradeItemHolder");
        OpenFunction = GameObject.Find("OpenButton").GetComponent<OpenAndClose>();
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        

        if (Input.GetMouseButtonDown(0) && hitBox == Physics2D.OverlapPoint(mousePos))
        {
            GlobalData.SelectedTower = transform.parent.gameObject;
            Debug.Log(GlobalData.SelectedTower.name);
            OpenFunction.ShowShop();
            ShowUpgradeScreen();
        }
    }

    void ShowUpgradeScreen()
    {
        group = upgradeScreen.GetComponent<CanvasGroup>();
        group.alpha = 1f;
        group.blocksRaycasts = true;

    }
}
