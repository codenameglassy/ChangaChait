using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitScore : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<ScoreManager>().SumbitScore();
    }
}
