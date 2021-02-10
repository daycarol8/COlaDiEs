using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMapa : MonoBehaviour
{
    private int mapCount;
    [SerializeField] private SpriteRenderer mapArt;
    [SerializeField] private Sprite map2;

    private void Start()
    {
        mapCount = PlayerPrefs.GetInt("Mapa");
        if (mapCount == 2){
            MapaDois();
        }
    }

    void MapaDois(){
        mapArt.sprite = map2;
    }
}
