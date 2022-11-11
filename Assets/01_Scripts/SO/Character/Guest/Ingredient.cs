using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/In")]
public class Ingredient : ScriptableObject
{
    [field : SerializeField] public IngredientList i = new IngredientList();
}

[System.Serializable]
public class IngredientList
{
    [Header("�ܰ�")]
    public float level; // �ʱ� �ܰ�

    [Header("���")]
    public int sheepMeat; // ����
    public int cowMeat; // �Ұ��

    [Header("ä��")]
    public int cabbage; // ����
    public int pakChoi; // û��ä
    public int pangiMushroom; // ���̹���
    public int pyogoMushroom; // ǥ�����
    public int sasongiMushroom; // ������ ����
    public int blackMushroom; // ���̹���
    public int mungSporout; // ����
    public int sweetPotato; // ����
    public int potato; // ����

    [Header("��")]
    public int cornMeon; // ��������
    public int oriDang; // �⺻ ���
    public int wideDang; // ���� ���
    public int boonMoJa; // �и��� ���

    [Header("��ġ")]
    public int ggochi; // ���첿ġ
    public int meatBall; // ����

    [Header("��Ÿ")]
    public int dryTofu; // �ǵκ�
    public int puju; // Ǫ��
    public int cheezeTt; // ġ�
    public int sweetTt; // ������
    public int quailEgg; // ���߸���
    public int sausage; // �Ҽ���
}
