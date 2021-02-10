using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandBehaviour : MonoBehaviour
{

    private Vector3 mousePosition;
    [SerializeField] private float moveSpeed;
    [SerializeField] public GameObject postItMain, postIt;
    [SerializeField] private SpriteRenderer setPostIts, setPostItsBullet;
    [SerializeField] private Sprite postItFloat, postItChar, postItInt, postItString, postItTrue, postItFalse;
    [SerializeField] private Sprite[] setSprites;
    public SpriteRenderer setLocked;
    public float count;
    public bool trocaPost;
    public Image red;
    private bool atirar;

    void Start(){
        atirar = true;
        setSprites = new Sprite[] { postItChar, postItInt, postItTrue, postItFloat, postItString };
        trocaPost = true;
        setLocked.sprite = postItMain.GetComponent<PostBehaviour>().locked1;
    }

    void Update(){

        postItMain.GetComponent<PostBehaviour>().hand = this.gameObject;
        Move();
        if (trocaPost){
            ThrowPostIt();
        }
    }

    void Move(){

        if (Input.GetMouseButton(0)){
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition = new Vector3(mousePosition.x, mousePosition.y);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }

    void ThrowPostIt(){

        if (Input.GetMouseButtonUp(0)){
            switch (count){
                case 0:
                    setPostIts.sprite = postItInt;
                    setPostItsBullet.sprite = postItChar;
                    trocaPost = false;
                    break;
                case 1:
                    setPostIts.sprite = postItTrue;
                    setPostItsBullet.sprite = postItInt;
                    trocaPost = false;
                    break;
                case 2:
                    setPostIts.sprite = postItFloat;
                    setPostItsBullet.sprite = postItTrue;
                    trocaPost = false;
                    break;
                case 3:
                    setPostIts.sprite = postItString;
                    setPostItsBullet.sprite = postItFloat;
                    trocaPost = false;
                    break;
                case 4:
                    Destroy(postIt);
                    setPostItsBullet.sprite = postItString;
                    trocaPost = false;
                    Invoke("Final", 1f);
                    break;
                default:
                    atirar = false;
                    break;
            }

            Vector3 m = new Vector3(transform.position.x - 0.5365f, transform.position.y + 0.81f);
            if (atirar){
                Instantiate(postItMain, m, Quaternion.identity);
            }

        }
    }
    void Final(){
        SceneManager.LoadScene(5);
        PlayerPrefs.SetInt("Mapa", 2);
    }
}
