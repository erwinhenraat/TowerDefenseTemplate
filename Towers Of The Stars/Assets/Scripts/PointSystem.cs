using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{

    public int GiveCC;
    void Start()
    {
        
    }

    void Update()
    {
        if(GiveCC >= 5)
        {
            GiveCC -= 5;
            AddCC();
        }
    }

    public void AddPoints(int points)
    {
        GlobalData.PlayerPoint += points;
        GiveCC += points;
    }

    public void AddCC()
    {
        GlobalData.CloudCoins += 1;
    }
}
