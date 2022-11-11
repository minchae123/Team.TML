using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Ingeredient
{
    sheep,
    cow,
    cabbage,
    parkChoi,
    pangi,
    pyogo,
    sasaongi,
    black,
    mungSporount,
    sweetPotato,
    potato,
    cornMeon,
    oriDang,
    wideDang,
    boonMoJa,
    gooChi,
    meatBall,
    dryTofu,
    puju,
    cheezeTt,
    sweetTt,
    egg,
    sausage
}

public class DicIngredient : MonoBehaviour
{
    [field:SerializeField] public Ingeredient[] ja;
    public Dictionary<Ingeredient, int> sets = new Dictionary<Ingeredient, int>();
    public Dictionary<Ingeredient, string> names = new Dictionary<Ingeredient, string>();

    public void GetList()
    {
        foreach(var item in ja)
        {
            sets.Add(item, 1);
        }
    }

    public void SetName()
    {
        names.Add(Ingeredient.sheep, "����");
        names.Add(Ingeredient.cow, "�Ұ��");
        names.Add(Ingeredient.cabbage, "����");
        names.Add(Ingeredient.parkChoi, "û��ä");
        names.Add(Ingeredient.pangi, "���̹���");
        names.Add(Ingeredient.pyogo, "ǥ�����");
        names.Add(Ingeredient.sasaongi, "�����̹���");
        names.Add(Ingeredient.black, "���̹���");
        names.Add(Ingeredient.mungSporount, "����");
        names.Add(Ingeredient.sweetPotato, "����");
        names.Add(Ingeredient.potato, "����");
        names.Add(Ingeredient.cornMeon, "��������");
        names.Add(Ingeredient.oriDang, "���");
        names.Add(Ingeredient.wideDang, "�������");
        names.Add(Ingeredient.boonMoJa, "�и���");
        names.Add(Ingeredient.gooChi, "��ġ");
        names.Add(Ingeredient.meatBall, "����");
        names.Add(Ingeredient.dryTofu, "�ǵκ�");
        names.Add(Ingeredient.puju, "Ǫ��");
        names.Add(Ingeredient.cheezeTt, "ġ�");
        names.Add(Ingeredient.sweetTt, "������");
        names.Add(Ingeredient.egg, "���߸���");
        names.Add(Ingeredient.sausage, "�Ҽ���");
    }
}
 