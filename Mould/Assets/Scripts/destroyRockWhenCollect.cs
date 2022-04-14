using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//CONSUME
//lmao I used a tutorial for the first part of this
public class destroyRockWhenCollect : MonoBehaviour
{
    //the things have to be triggers for this to work
    //this kills rock
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        //gameObject = rock

        //SceneManager.UnloadScene("Level1");
        SceneManager.LoadScene("Level2");

    }
}
