using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInicio : MonoBehaviour
{

    public void SetInicio(){
        SceneManager.LoadScene(1);
    }
}
