using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    float distance = 2f;
    float dist;
    public GameObject character;
    public GameObject text;
    public GameObject canvas;
    


    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(character.transform.position, transform.position);
        if (dist < distance){
            text.SetActive(true);
            canvas.SetActive(false);
        }
    }
}
