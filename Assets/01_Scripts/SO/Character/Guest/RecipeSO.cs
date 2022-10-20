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
    public static int pakchoi; // û��ä
    public static int enokimushroom; // ���̹���
    public static int oystermushroom; // ��Ÿ������
    public static int pyomushroom; // ǥ�����
    public static int sasongmushroom; // ������ ����
    public static int blackmushroom; // ���̹���
    public static int beansprout; // �ᳪ��
    public static int mungsporout; // ����
    public static int sweetpoatao; // ����
    public static int poatao; // ����
    public static int cilantro; // ���
    public static int crowndaisy; // ����
    public static int bamboo; // �׼�
    public static int rotusroot; // ����
    public int[] vegetable = new int[] { cabbage, pakchoi, enokimushroom, oystermushroom, sasongmushroom, sasongmushroom, blackmushroom,
        beansprout, mungsporout, sweetpoatao, poatao, cilantro, crowndaisy, rotusroot };

    [Header("��")]
    public static int corn; // ��������
    public static int oriDang; // �⺻ ���
    public static int wideDang; // ���� ���
    public static int boonMoJa; // �и��� ���
    public static int raMeon; // ���縮
    public int[] noodle = new int[] { corn, oriDang, wideDang, boonMoJa, raMeon};

    [Header("��ġ")]
    public static int shrimp; // ���첿ġ
    public static int octopus; // ���ġ
    public static int squid; // ��¡�ġ
    public static int meatBall; // ����
    public int[] stick = new int[] { shrimp, octopus, squid, meatBall};

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
    public int[] etc = new int[] { dryTofu, froTofu, froTofu, puju, doupi, cheezeTt, 
        sweetTt, tteok, crabStick, sujebi, fishCake, quailEgg, sausage };
}
