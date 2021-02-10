using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class SetText : MonoBehaviour
    {
        [SerializeField] private Image b1;
        [SerializeField] private SpriteRenderer m1, m2;
        [SerializeField] private Sprite m3;
        [SerializeField] private GameObject b2, b3;
        
        public void PassText(){
            Destroy(b1);
            m1.enabled = false;
            b2.active = true;
        }

        public void PassText2(){
            m2.sprite = m3;
            Destroy(b2);
            b3.active = true;
        }    

        public void SetFaseUm(){
            SceneManager.LoadScene(4);
        }
    }
