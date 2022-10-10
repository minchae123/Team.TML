using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("SO/Chararcter/Recipe"))]
public class GuestRecipeSO : ScriptableObject
{
    [Header("단계")]
    public float level; // 맵기 단계

    [Header("고기")]
    public int sheepMeat; // 양고기
    public int cowMeat; // 소고기

    [Header("채소")]
    public int cabbage; // 배추
    public int pakChoi; // 청경채
    public int enokiMushroom; // 팽이버섯
    public int oysterMushroom; // 느타리버섯
    public int blackMushroom; // 목이버섯
    public int beanSprout; // 콩나물
    public int mungSporout; // 숙주
    public int sweetPoatao; // 고구마
    public int poatao; // 감자
    public int cilantro; // 고수
    public int crownDaisy; // 쑥갓
    public int bamboo; // 죽순
    public int rotusRoot; // 연근

    [Header("면")]
    public int corn; // 옥수수면
    public int oriDang; // 기본 당면
    public int wideDang; // 넓적 당면
    public int boonMoJa; // 분모자 당면
    public int raMeon; // 라면사리

    [Header("꼬치")]
    public int shrimp; // 새우꼬치
    public int octopus; // 문어꼬치
    public int squid; // 오징어꼬치
    public int meatBall; // 완자


    [Header("기타")]
    public int dryTofu; // 건두부
    public int froTofu; // 언두부
    public int firedTofu; // 유부
    public int puju; // 푸주
    public int doupi; // 두유피
    public int cheezeTt; // 치즈떡
    public int sweetTt; // 고구마떡
    public int tteok; // 떡국떡
    public int crabStick; // 게맛살
    public int sujebi; // 수제비
    public int fishCake; // 어묵
    public int quailEgg; // 메추리알
    public int sausage; // 소세지
}
