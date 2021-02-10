using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PostBehaviour : MonoBehaviour
{
    [SerializeField] private Sprite locked2, locked3, locked4, locked5, locked6;
    public Sprite locked1;
    [SerializeField] private Sprite[] Lockeds;
    [SerializeField] private SpriteRenderer setLocked;
    [SerializeField] private float speed;
    public GameObject hand;
    private float count;

    void Start(){
        count = hand.GetComponent<HandBehaviour>().count;
        setLocked = hand.GetComponent<HandBehaviour>().setLocked;
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Char" && count == 0){
            hand.GetComponent<HandBehaviour>().count += 1;
            Destroy(this.gameObject, 0.3f);
            hand.GetComponent<HandBehaviour>().trocaPost = true;
            setLocked.sprite = locked2;
        }
        else if (collision.gameObject.tag == "Int" && count == 1){
            hand.GetComponent<HandBehaviour>().count += 1;
            Destroy(this.gameObject, 0.3f);
            hand.GetComponent<HandBehaviour>().trocaPost = true;
            setLocked.sprite = locked3;
        }
        else if (collision.gameObject.tag == "Bool" && count == 2){
            hand.GetComponent<HandBehaviour>().count += 1;
            Destroy(this.gameObject, 0.3f);
            hand.GetComponent<HandBehaviour>().trocaPost = true;
            setLocked.sprite = locked4;
        }
        else if (collision.gameObject.tag == "Float" && count == 3){
            hand.GetComponent<HandBehaviour>().count += 1;
            Destroy(this.gameObject, 0.3f);
            hand.GetComponent<HandBehaviour>().trocaPost = true;
            setLocked.sprite = locked5;
        }
        else if (collision.gameObject.tag == "String" && count == 4){
            hand.GetComponent<HandBehaviour>().count += 1;
            hand.GetComponent<HandBehaviour>().trocaPost = true;
            setLocked.sprite = locked6;
            Destroy(this.gameObject);
        }
        else{
            hand.GetComponent<HandBehaviour>().red.enabled = true;
            Invoke("TimeReset", 1f);
        }
    }

    void TimeReset(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
