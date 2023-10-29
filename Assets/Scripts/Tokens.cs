using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    private Transform pos;
    public Vector3[] tokensPos = new Vector3[35]; //positions array
    

    public GameObject tokensPrefab;
    private int tokensIndex;

    private float gridMoveTimer;
    private float gridMoveTimerMax = 1f; //the token appears every 3 seconds

    private bool isPaused = false;


    private void Update()
    {
        SpawnTokens();
        
    }

    private void SpawnTokens()
    {
        gridMoveTimer += Time.deltaTime;
        if (gridMoveTimer >= gridMoveTimerMax)
        {
            gridMoveTimer -= gridMoveTimerMax; // tempo se reinicia

            
            //the token appears in random positions
            float posx = Random.Range(-3, 3);
            float posy = Random.Range(-2, 2);
            Vector2 randomPos = new Vector2(posx, posy);

            tokensIndex = Random.Range(0, tokensPos.Length);
            Instantiate(tokensPrefab, tokensPos[tokensIndex], Quaternion.identity);
        }
        
    }

    /*private void OccupiedPositions() //stop time when all positions are occupied
    {
       if(tokensPrefab <= 35)
        {
            SpawnTokens();
        }
        else
        {

        }
    }*/
}
