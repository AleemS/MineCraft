﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLandscape_03 : MonoBehaviour {
    public int worldSizeW = 64;
    public int worldSizeH = 64;
    public float heightScale = 20;
    public float detailScale = 25.0f;

    public GameObject prefabGrass;
    // Use this for initialization
    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        float ofsX = Random.Range(0, 10);
        float ofsZ = Random.Range(0, 10);
        for (int z = 0; z < worldSizeH; z++)
        {
            for (int x = 0; x < worldSizeW; x++)
            {
                float fx = ofsX + x / detailScale;
                float fz = ofsZ + z / detailScale;
                int y = (int)(Mathf.PerlinNoise(x / detailScale, z / detailScale) * heightScale);
                    Vector3 pos = new Vector3(x, y, z);
                Instantiate(prefabGrass, pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
