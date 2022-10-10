using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/Guest/Recipe")]
public class RecipeSO : ScriptableObject
{
    [Header("�ܰ�")]
    public float level;

    [Header("���")]
    public static int sheep; // ����
    public static int cow; // �Ұ��
    public int[] meat = new int[] { sheep, cow };

    [Header("ä��")]
    public static int cabbage; // ����
    public static int pakChoi; // û��ä
    public static int enokiMushroom; // ���̹���
    public static int oysterMushroom; // ��Ÿ������
    public static int blackMushroom; // ���̹���
    public static int beanSprout; // �ᳪ��
    public static int mungSporout; // ����
    public static int sweetPoatao; // ����
    public static int poatao; // ����
    public static int cilantro; // ���
    public static int crownDaisy; // ����
    public static int bamboo; // �׼�
    public static int rotusRoot; // ����
    public int[] ve = new int[] { cabbage, pakChoi, enokiMushroom, oysterMushroom, blackMushroom, beanSprout, mungSporout, sweetPoatao, poatao, cilantro, crownDaisy, rotusRoot };

    [Header("��")]
    public static int corn; // ��������
    public static int oriDang; // �⺻ ���
    public static int wideDang; // ���� ���
    public static int boonMoJa; // �и��� ���
    public static int raMeon; // ���縮
    public static int[] noodle = new int[] { corn, oriDang, wideDang, boonMoJa, raMeon};

    [Header("��ġ")]
    public static int shrimp; // ���첿ġ
    public static int octopus; // ���ġ
    public static int squid; // ��¡�ġ
    public static int meatBall; // ����
    public int[] stick = new int[] { };

    [Header("��Ÿ")]
    public static int dryTofu; // �ǵκ�
    public static int froTofu; // ��κ�
    public static int firedTofu; // ����
    public static int puju; // Ǫ��
    public static int doupi; // ������
    public static int cheezeTt; // ġ�
    public static int sweetTt; // ������
    public static int tteok; // ������
    public static int crabStick; // �Ը���
    public static int sujebi; // ������
    public static int fishCake; // �
    public static int quailEgg; // ���߸���
    public static int sausage; // �Ҽ���
    public int[] etc = new int[] { dryTofu, froTofu, froTofu, puju, doupi, cheezeTt, sweetTt, tteok, crabStick, sujebi, fishCake, quailEgg, sausage };
}
