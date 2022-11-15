using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Meat
{
    ����, �Ұ��
}

public enum Vegetable
{
    ����, û��ä, ���̹���, ǥ�����, �����̹���, ���̹���, ����, ����, ����
}

public enum Noodle
{
    ��������, ���, �������, �и��ڴ��
}

public enum Etc
{
    ��ġ, ����, �ǵκ�, Ǫ��, ġ�, ������, ���߸���, �Ҽ���
}

[CreateAssetMenu(menuName ="SO/Recipe")]
public class IngredientSO : ScriptableObject
{
    public int level;
    public Sprite sp;

    [Header("���")]
    public List<Meat> meatList;

    [Header("ä��")]
    public List<Vegetable> vegetableList;

    [Header("��")] 
    public List<Noodle> noodleList;

    [Header("��Ÿ")]
    public List<Etc> etcList;
}
