using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantUpgrade : MonoBehaviour
{
    private NamBi _namBi;
    private void Awake() {
        _namBi = GameObject.Find("DroppableUI").GetComponent<NamBi>();
    }
    public void Level2(){
        _namBi.upLevel = 2;
        
    }

    public void Level3(){
        _namBi.upLevel = 3;
    }
}
