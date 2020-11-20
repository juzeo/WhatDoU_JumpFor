using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DataSave
{
    public int Coin;
    public List<string> UnlockList_name;
    public List<bool> UnlockList_bool;
    public List<CharacterNCoin> UnlockList
    {
        get
        {
            List<CharacterNCoin> returnList = new List<CharacterNCoin>();
            for (int i = 0; i < UnlockList_name.Count; i++)
            {
                CharacterNCoin temp = new CharacterNCoin();
                temp.Create(UnlockList_name[i], UnlockList_bool[i]);
                returnList.Add(temp);
                
            }
            return returnList;
        }
      
    }


}
