using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    private Chessboard chessboard; // for setup

    private Transform pos;
    public Vector3[] tokensPos = new Vector3[35]; //positions array
    

    public GameObject tokensPrefab;
    private int tokensIndex;

    private float gridMoveTimer;
    private float gridMoveTimerMax = 3f; //the token appears every 3 seconds


    private void Update()
    {
        SpawnTokens();
        OccupiedPositions();
    }

    private void SpawnTokens()
    {
        if (gridMoveTimer >= gridMoveTimerMax)
        {
            gridMoveTimer -= gridMoveTimerMax;
        }

        //the token appears in random positions
        float posx = Random.Range(-3, 3);
        float posy = Random.Range(-2, 2);
        Vector2 randomPos = new Vector2(posx, posy);
          
        tokensIndex = Random.Range(0, tokensPos.Length);
        Instantiate(tokensPrefab, tokensPos[tokensIndex], tokensPrefab.transform.rotation);
    }

    private void OccupiedPositions() //stop time when all positions are occupied
    {
        if(tokensIndex >= tokensPos.Length)
        {
            Time.timeScale = 0; 
        }
        else
        {
            SpawnTokens();
        }
    }

    //Scripts connection
    public void Setup(Chessboard chessboard)  //public function that needs info of the script Chessboard
    {
        this.chessboard = chessboard;
    }
}
