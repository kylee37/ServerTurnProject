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
        Debug.Log($"���� ü��: {finalHP}");
        Debug.Log($"���� ���ݷ�: {finalATK}");
        Debug.Log($"���� ����: {finalDEF}");
        Debug.Log($"���� ȸ����: {evade * 100} %");
        Debug.Log($"��� ���ݿ� ���� ������: {damageRestruction * 100} %");
        Debug.Log($"�������� ����� ���ط�: {finalATK * damageRestruction}");
    }

    // �г� �ݰų� �ϴ� ���� ���ǽ�(���� �Ѿ�� ��)�� ������ ����
    void StatUpdate()
    {
        finalHP = characterStat.HP * 1000;
        finalATK = characterStat.ATK * 100;
        finalDEF = characterStat.DEF * 100;
        finalEVA = characterStat.EVA * 100;
    }
    
    void Evade()
    {
        evade = (finalEVA / (finalEVA + 2000));     // ��� ������ ȸ���� Ȯ��
    }

    void DamageRestruction()
    {
        damageRestruction = (finalDEF/(finalDEF+450));
    }
}
