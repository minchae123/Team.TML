using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/Guest/Recipe")]
public class RecipeSO : ScriptableObject
{
    [Header("단계")]
    public float level;

    [Header("고기")]
    public static int sheep; // 양고기
    public static int cow; // 소고기
    public int[] meat = new int[] { sheep, cow };

    [Header("채소")]
    public static int cabbage; // 배추
    public static int pakchoi; // 청경채
    public static int enokimushroom; // 팽이버섯
    public static int oystermushroom; // 느타리버섯
    public static int pyomushroom; // 표고버섯
    public static int sasongmushroom; // 새송이 버섯
    public static int blackmushroom; // 목이버섯
    public static int beansprout; // 콩나물
    public static int mungsporout; // 숙주
    public static int sweetpoatao; // 고구마
    public static int poatao; // 감자
    public static int cilantro; // 고수
    public static int crowndaisy; // 쑥갓
    public static int bamboo; // 죽순
    public static int rotusroot; // 연근
    public int[] vegetable = new int[] { cabbage, pakchoi, enokimushroom, oystermushroom, sasongmushroom, sasongmushroom, blackmushroom,
        beansprout, mungsporout, sweetpoatao, poatao, cilantro, crowndaisy, rotusroot };

    [Header("면")]
    public static int corn; // 옥수수면
    public static int oriDang; // 기본 당면
    public static int wideDang; // 넓적 당면
    public static int boonMoJa; // 분모자 당면
    public static int raMeon; // 라면사리
    public int[] noodle = new int[] { corn, oriDang, wideDang, boonMoJa, raMeon};

    [Header("꼬치")]
    public static int shrimp; // 새우꼬치
    public static int octopus; // 문어꼬치
    public static int squid; // 오징어꼬치
    public static int meatBall; // 완자
    public int[] stick = new int[] { shrimp, octopus, squid, meatBall};

    [Header("기타")]
    public static int dryTofu; // 건두부
    public static int froTofu; // 언두부
    public static int firedTofu; // 유부
    public static int puju; // 푸주
    public static int doupi; // 두유피
    public static int cheezeTt; // 치즈떡
    public static int sweetTt; // 고구마떡
    public static int tteok; // 떡국떡
    public static int crabStick; // 게맛살
    public static int sujebi; // 수제비
    public static int fishCake; // 어묵
    public static int quailEgg; // 메추리알
    public static int sausage; // 소세지
    public int[] etc = new int[] { dryTofu, froTofu, froTofu, puju, doupi, cheezeTt, 
        sweetTt, tteok, crabStick, sujebi, fishCake, quailEgg, sausage };
}
