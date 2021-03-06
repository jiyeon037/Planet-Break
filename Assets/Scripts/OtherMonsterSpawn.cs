﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherMonsterSpawn : MonoBehaviour {

    public int monsterMax;
    public GameObject monster;
    public float createTime = 3f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("SpawnMonster");
    }

    IEnumerator SpawnMonster()
    {
        float randomX = Random.Range(-32, 23);
        float randomY = Random.Range(-20, 13);

        int monsterCount = (int)GameObject.FindGameObjectsWithTag("Monster").Length;

        Debug.Log("Monster Spawned : " + monsterCount);

        if (monsterCount < monsterMax)
        {
            yield return new WaitForSeconds(createTime);

            Instantiate(monster, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        }
        else
        {
            yield return new WaitForSeconds(createTime);
        }

        StartCoroutine("SpawnMonster");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
