using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{

    public Vector3[] tokensPos = new Vector3[35]; //positions array
    public GameObject tokensPrefab;
    private int tokensIndex;


    private float gridMoveTimer;
    private float gridMoveTimerMax = 1f; //the token appears every 3 seconds

    private void Update()
    {
        SpawnTokens();
       // EndGame();
    }

    private void SpawnTokens()
    {
        gridMoveTimer += Time.deltaTime;
        if (gridMoveTimer >= gridMoveTimerMax)
        {
            gridMoveTimer -= gridMoveTimerMax; // the token appears every 3 seconds


            //the token appears in random positions
            float posx = Random.Range(-3, 3);
            float posy = Random.Range(-2, 2);
            Vector2 randomPos = new Vector2(posx, posy);

            tokensIndex = Random.Range(0, tokensPos.Length);
            Instantiate(tokensPrefab, tokensPos[tokensIndex], Quaternion.identity);
        }


    }

    /*private void EndGame() //instantiation stop when all the squares on the chessboard are occupied
    {
        if (tokensPrefab >= 35)
        {
            Time.timeScale = 0;
            Debug.Log("stop");
        }
        else
        {
            SpawnTokens()
            Debug.Log("play");
        }
    }*/

    //He intentado resolver la función de mil maneras y no doy con la solución.
}
