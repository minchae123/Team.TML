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
        names.Add(Ingeredient.sheep, "양고기");
        names.Add(Ingeredient.cow, "소고기");
        names.Add(Ingeredient.cabbage, "배추");
        names.Add(Ingeredient.parkChoi, "청경채");
        names.Add(Ingeredient.pangi, "팽이버섯");
        names.Add(Ingeredient.pyogo, "표고버섯");
        names.Add(Ingeredient.sasaongi, "새송이버섯");
        names.Add(Ingeredient.black, "목이버섯");
        names.Add(Ingeredient.mungSporount, "숙주");
        names.Add(Ingeredient.sweetPotato, "고구마");
        names.Add(Ingeredient.potato, "감자");
        names.Add(Ingeredient.cornMeon, "옥수수면");
        names.Add(Ingeredient.oriDang, "당면");
        names.Add(Ingeredient.wideDang, "넓적당면");
        names.Add(Ingeredient.boonMoJa, "분모자");
        names.Add(Ingeredient.gooChi, "꼬치");
        names.Add(Ingeredient.meatBall, "완자");
        names.Add(Ingeredient.dryTofu, "건두부");
        names.Add(Ingeredient.puju, "푸주");
        names.Add(Ingeredient.cheezeTt, "치즈떡");
        names.Add(Ingeredient.sweetTt, "고구마떡");
        names.Add(Ingeredient.egg, "메추리알");
        names.Add(Ingeredient.sausage, "소세지");
    }
}
 