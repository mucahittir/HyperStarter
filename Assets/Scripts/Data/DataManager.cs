using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : CoreObj<DataManager>
{

    private int level;
    private long money;

    public int Level { get => level; set => level = value; }
    public long Money { get => money; set => money = value; }

    public override void Initialize()
    {
        if(PlayerPrefs.HasKey("Level"))
        {
            level = PlayerPrefs.GetInt("Level");
        }
        if(PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }
    }
}
