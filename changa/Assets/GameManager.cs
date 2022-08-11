using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameoverView;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Invoke_ShowGameOver()
    {
        Invoke("ShowGameOver", .8f);
    }
    void ShowGameOver()
    {
        gameoverView.SetActive(true);
    }
}
