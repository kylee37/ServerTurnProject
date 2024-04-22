using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Status : MonoBehaviour
{
    private float finalHP;
    private float finalATK;
    private float finalDEF;
    private float finalEVA;
            
    private float damageRestruction;
    private float evade;

    CharacterStat characterStat;

    private void Awake()
    {
        characterStat = FindObjectOfType<CharacterStat>();
    }

    void Start()
    {
        finalHP = characterStat.HP * 1000;
        finalATK = characterStat.ATK * 100;
        finalDEF = characterStat.DEF * 100;
        finalEVA = characterStat.EVA * 100;
        Evade();
        DamageRestruction();
        Debug.Log($"최종 체력: {finalHP}");
        Debug.Log($"최종 공격력: {finalATK}");
        Debug.Log($"최종 방어력: {finalDEF}");
        Debug.Log($"최종 회피율: {evade * 100} %");
        Debug.Log($"상대 공격에 대한 감소율: {damageRestruction * 100} %");
        Debug.Log($"감소율이 적용된 피해량: {finalATK * damageRestruction}");
    }

    // 패널 닫거나 하는 등의 조건식(게임 넘어가기 전)에 넣으면 재계산
    void StatUpdate()
    {
        finalHP = characterStat.HP * 1000;
        finalATK = characterStat.ATK * 100;
        finalDEF = characterStat.DEF * 100;
        finalEVA = characterStat.EVA * 100;
    }
    
    void Evade()
    {
        evade = (finalEVA / (finalEVA + 2000));     // 상대 공격을 회피할 확률
    }

    void DamageRestruction()
    {
        damageRestruction = (finalDEF/(finalDEF+450));
    }
}
