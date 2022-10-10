using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("SO/Chararcter/Recipe"))]
public class GuestRecipeSO : ScriptableObject
{
    [Header("�ܰ�")]
    public float level; // �ʱ� �ܰ�

    [Header("���")]
    public int sheepMeat; // ����
    public int cowMeat; // �Ұ��

    [Header("ä��")]
    public int cabbage; // ����
    public int pakChoi; // û��ä
    public int enokiMushroom; // ���̹���
    public int oysterMushroom; // ��Ÿ������
    public int blackMushroom; // ���̹���
    public int beanSprout; // �ᳪ��
    public int mungSporout; // ����
    public int sweetPoatao; // ����
    public int poatao; // ����
    public int cilantro; // ���
    public int crownDaisy; // ����
    public int bamboo; // �׼�
    public int rotusRoot; // ����

    [Header("��")]
    public int corn; // ��������
    public int oriDang; // �⺻ ���
    public int wideDang; // ���� ���
    public int boonMoJa; // �и��� ���
    public int raMeon; // ���縮

    [Header("��ġ")]
    public int shrimp; // ���첿ġ
    public int octopus; // ���ġ
    public int squid; // ��¡�ġ
    public int meatBall; // ����


    [Header("��Ÿ")]
    public int dryTofu; // �ǵκ�
    public int froTofu; // ��κ�
    public int firedTofu; // ����
    public int puju; // Ǫ��
    public int doupi; // ������
    public int cheezeTt; // ġ�
    public int sweetTt; // ������
    public int tteok; // ������
    public int crabStick; // �Ը���
    public int sujebi; // ������
    public int fishCake; // �
    public int quailEgg; // ���߸���
    public int sausage; // �Ҽ���
}
