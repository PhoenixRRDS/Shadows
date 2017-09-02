/*
 * Noise.cs
 * Copyright (c) 2017 Rudra Nil Basu <rudra.nil.basu.1996@gmail.com>
 * AUTHORS
 * Rudra Nil Basu <rudra.nil.basu.1996@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise {

    #region Variables
    #endregion

    #region Unity Methods
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale)
    {
        float[,] noiseMap = new float[mapWidth, mapHeight];

        if (scale == 0.0f) {
            scale = 0.0001f;
        }

        for (int y = 0; y < mapHeight; y++) {
            for (int x = 0; x < mapWidth; x++) {
                float sampleX = x / scale;
                float sampleY = y / scale;

                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);

                noiseMap[x, y] = perlinValue;
            }
        }

        return noiseMap;
    }
    #endregion
}
