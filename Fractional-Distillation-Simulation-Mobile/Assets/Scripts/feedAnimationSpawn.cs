﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedAnimationSpawn : MonoBehaviour
{
    public GameObject feedLiquidDropletPrefab;
    public float SCALE = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //spawn liquid droplet
        StartCoroutine(FeedLiquidFlow());
    }

    private IEnumerator FeedLiquidFlow()
    {
        //Vector3 feedLocalPos = new Vector3(0, -0.695f, 0);
        //Vector3 feedLocalPos = new Vector3(-200f, -10, 180f) * SCALE;
        int moleculeCount = 0;
        while (moleculeCount <= 23)
        {
            //feed column is 375 wide
            GameObject feedLiquid = (GameObject)Instantiate(feedLiquidDropletPrefab, transform);
            //feedLiquid.transform.localPosition = transform.localPosition + feedLocalPos;
            feedLiquid.GetComponent<setColour>().liqCon = 0.5f;
            moleculeCount++;
            yield return new WaitForSeconds(0.25f);
        }

    }

}
