using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject imp;
    public GameObject impShot;

    public GameObject[] spawnpoint;

    public int maxImps;

    public int livingImps;

    public int maxRounds;

    int round;

    public int shooterSpawnPersentage;

    public Text roundText;

    public GameObject winScreen;

    void Start()
    {
        maxImps = 3;
        round = 1;
        Spawn();
    }

    void Update()
    {
        if (round <= maxRounds)
        {

            if (livingImps == 0)
            {
                round++;
                maxImps += 2;
                Spawn();
            }

            roundText.text = "Round " + round;
        }
        else
        {
            winScreen.SetActive(true);
        }
    }

    void Spawn()
    {
        livingImps = maxImps;
        GameObject newImp;
        for (int i = 0; i < maxImps; i++)
        {
            var randomizer = (int)Random.Range(0, 100);
            var randomSpawn = (int)Random.Range(0, spawnpoint.Length);
            if (randomizer > shooterSpawnPersentage)
            {
                newImp = Instantiate(impShot, spawnpoint[randomSpawn].transform.position, Quaternion.identity);
                newImp.SetActive(true);
            }
            else
            {
                newImp = Instantiate(imp, spawnpoint[randomSpawn].transform.position, Quaternion.identity);
                newImp.SetActive(true);
            }
        }
    }

    public void KillImp()
    {
        livingImps--;
    }
}
