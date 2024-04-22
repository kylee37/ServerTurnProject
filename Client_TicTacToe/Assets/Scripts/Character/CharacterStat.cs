using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    public int SP { get; private set; }
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int EVA { get; private set; }

    TextLoader textLoader;

    private void Awake()
    {
        ResetSP();
        textLoader = GameObject.Find("Text").GetComponent<TextLoader>();
    }

    public void StatUp(string StatName)
    {
        if (StatName == "RESET")
        {
            SP = 10;
            HP = 3;
            ATK = 3;
            DEF = 3;
            EVA = 3;
            textLoader.UpdateText();
        }
        else if (SP > 0)
        {
            switch (StatName)
            {
                case "HP":
                    HP++;
                    Debug.Log($"HP : {HP}");
                    break;
                case "ATK":
                    ATK++;
                    Debug.Log($"ATK : {ATK}");
                    break;
                case "DEF":
                    DEF++;
                    Debug.Log($"DEF : {DEF}");
                    break;
                case "EVA":
                    EVA++;
                    Debug.Log($"EVA : {EVA}");
                    break;
            }
            SP--;
            textLoader.UpdateText();
            Debug.Log($"SP : {SP}");
        }
    }

    public void ResetSP()
    {
        SP = 10;
        HP = 3;
        ATK = 3;
        DEF = 3;
        EVA = 3;
    }
}


