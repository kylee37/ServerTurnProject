using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextLoader : MonoBehaviour
{
    CharacterStat playerStat;

    private void Start()
    {
        playerStat = GameObject.Find("Swordcharacter").GetComponent<CharacterStat>();

        UpdateText();
    }

    public TextMeshProUGUI SP;
    public TextMeshProUGUI HP;
    public TextMeshProUGUI ATK;
    public TextMeshProUGUI DEF;
    public TextMeshProUGUI EVA;

    public void UpdateText()
    {
        Debug.Log("asdsd");
        SP.text = $"SP : {playerStat.SP}";
        HP.text = $"SP : {playerStat.HP}";
        ATK.text = $"SP : {playerStat.ATK}";
        DEF.text = $"SP : {playerStat.DEF}";
        EVA.text = $"SP : {playerStat.EVA}";
    }
}
