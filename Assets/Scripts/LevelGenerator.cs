using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private const float PLAYER_DISANCE_SPAWN_PLATORM = 15f;
    [SerializeField] private Transform levelPart_Start = null;
    [SerializeField] private List<Transform> PlatformList = new List<Transform>();
    [SerializeField] private Transform player = null;
    private Queue<GameObject> PlatformSeries = new Queue<GameObject>();

    private Vector3 lastEndPosition;


    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;

        int staringSpawnLevelParts = 5;
        for (int i = 0; i < staringSpawnLevelParts; i++)
        { 
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        //Create platform from set distance
        if (Vector3.Distance(player.position, lastEndPosition) < PLAYER_DISANCE_SPAWN_PLATORM)
        {
            SpawnLevelPart();
        }
    }

    //Choosing Level To Spawn in
    private void SpawnLevelPart()
    {
        Transform chosenPlatform = PlatformList[Random.Range(0, PlatformList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenPlatform, lastEndPosition);
        PlatformSeries.Enqueue(lastLevelPartTransform.gameObject);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
       /* Destroy(lastLevelPartTransform);*/
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
