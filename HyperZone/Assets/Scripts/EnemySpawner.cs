using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDistance = 50f;
    public Transform player;

    [System.Serializable]
    public class SpawnEvent
    {
        public float time;
        public Vector3 offset;
    }

    public SpawnEvent[] spawnEvents;

    private float gameTime = 0f;
    private int nextEventIndex = 0;

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;

        if(nextEventIndex < spawnEvents.Length
            && gameTime >= spawnEvents[nextEventIndex].time)
        {
            Vector3 spawnPos = player.position + new Vector3(
                spawnEvents[nextEventIndex].offset.x,
                spawnEvents[nextEventIndex].offset.y,
                30f);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            nextEventIndex += 1;
        }
    }
}
