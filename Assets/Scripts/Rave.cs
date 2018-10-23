using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rave : MonoBehaviour
{

    public SpriteRenderer[] rend;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            //for (loopar något)  
            //i är en temporär variabel  
            //rend.Lenght gör så att man inte behöver ändra här inne "bara i unity"
            for (int i = 0; i < rend.Length; i++)
            {
                rend[i].color = Random.ColorHSV(0f, 1f, 0f, 1f, 0.8f, 1f, 1f, 1f);
            }

        }

    }

}
