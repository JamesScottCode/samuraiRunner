using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public int textcounter = 0;
    public GameObject nextTile;
    public GameObject spawnedTile;
    private Vector3 currentLoc;
    private Vector3 nextLoc;
    private int floorLength = 20;
    private Vector3 spawnPos;
    private int numTilesAhead = 4; //how many tiles ahead
    public static int spawnCount = 0;
    public string floorName;

    public GameObject Coin;
    public GameObject rowLeftObj;
    public GameObject[] blockers;
    public GameObject fence;
    public int ranBlockNum;

    public Vector3 rowLeft;
    public Vector3 rowMid;
    public Vector3 rowRight;
    public Vector3 spawnShiftUp;
    public Vector3 row1;
    public Vector3 row3;
    public int ranNum1;
    Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

    List<int> RanNumsCol = new List<int>(){};
    List<int> RanNumsRow = new List<int>(){};
    List<int> ListTest = new List<int>() { };

    //loc arr of vector
    public Vector3[,] gridArr = { 
        { Vector3.left * 5 + Vector3.forward * 5, Vector3.left * 5, Vector3.left * 5 + Vector3.back * 5}, 
        { Vector3.forward * 5, Vector3.forward * 0, Vector3.back * 5 }, 
        { Vector3.right * 5 + Vector3.forward * 5, Vector3.right * 5, Vector3.right * 5 + Vector3.back * 5 } };

    //random array
    public int[] randomArr = new int[8];

    // Start is called before the first frame update
    void Start()
    {
        spawnCount += 1;
        floorName = "Floor" + spawnCount.ToString();
    }

    void OnTriggerEnter()
    {
        //location of next tile
        spawnPos = transform.position + Vector3.forward * (floorLength * numTilesAhead);
        spawnShiftUp = spawnPos + (Vector3.up * 4);

        //rows left mid right
        rowLeft = spawnPos + (Vector3.left * 5);
        rowMid = spawnPos;
        rowRight = spawnPos + (Vector3.right * 5);

        //rows 1 2 3
        row1 = Vector3.back * 5;
        row3 = Vector3.forward * 5;

        //spawning/naming
        spawnedTile = Instantiate(nextTile, spawnPos, transform.rotation);
        spawnedTile.name = floorName;

        //fences
        Instantiate(fence, spawnPos +(Vector3.up * 2.7f) + (Vector3.left * 1) , spawnRotation);
        Instantiate(fence, spawnPos + (Vector3.up * 2.7f) + (Vector3.right * 15.5f) , spawnRotation);
        spawnItems();
        SpawnCoin();
    }

    void spawnItems()
    {  
        RanListCol();
        RanListRow();
        Instantiate(blockers[randomBlocker()], spawnPos + gridArr[RanNumsCol.IndexOf(0), RanNumsRow.IndexOf(0)], transform.rotation);
        Instantiate(blockers[randomBlocker()], spawnPos + gridArr[RanNumsCol.IndexOf(1), RanNumsRow.IndexOf(1)], transform.rotation);
        Instantiate(blockers[randomBlocker()], spawnPos + gridArr[RanNumsCol.IndexOf(2), RanNumsRow.IndexOf(2)], transform.rotation);  
    }

    
    void RanListCol()
    {
        while (RanNumsCol.Count < 3)
        {
            ranNum1 = Random.Range(0, 3);
            if (RanNumsCol.Contains(ranNum1))
            {
                //space for future
            }
            else
            {
                RanNumsCol.Add(ranNum1);
            }
        }
    }

    void RanListRow()
    {
        while (RanNumsRow.Count < 3)
        {
           ranNum1 = Random.Range(0, 3);
            if (RanNumsRow.Contains(ranNum1))
            {
                //do nothing
            }
            else
            {
                RanNumsRow.Add(ranNum1);
            }
        }
     }

    int randomBlocker()
    {
        return Random.Range(0, blockers.Length);
    }

    void SpawnCoin()
    {
        Instantiate(Coin, spawnPos + Vector3.back * 10, transform.rotation);
        Instantiate(Coin, spawnPos + (Vector3.back * 10) + (Vector3.right * 5), transform.rotation);
        Instantiate(Coin, spawnPos + (Vector3.back * 10) + (Vector3.left * 5), transform.rotation);
    }
}

