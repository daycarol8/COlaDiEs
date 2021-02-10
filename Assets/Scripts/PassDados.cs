using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassDados : MonoBehaviour
{
    [SerializeField] private GameObject b1, b2;
    [SerializeField] private SpriteRenderer m1;
    [SerializeField] private Sprite m2;

    public void PassaDados(){
        b1.active = true;
        Destroy(b2);
        m1.sprite = m2;
    }
}
