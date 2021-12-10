using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject[] PlatformPref;
    public GameObject FirstPlatformPrefab;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float Distance;
    public Transform FinishPlatform;
    public Transform CilynderRoot;
    public float ExtraCilynderScale = 1f;


    private void Awake()
    {
        int platformCount = Random.Range(MinPlatforms, MaxPlatforms + 1);

        for (int i = 0; i < platformCount; i++)
        {
            int PrefabIndex = Random.Range(0, PlatformPref.Length);
            GameObject PlatformPrefab = i == 0 ? FirstPlatformPrefab : PlatformPref[PrefabIndex];
            GameObject platform = Instantiate(PlatformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if (i > 0)
            {
                platform.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
            }
        }

        FinishPlatform.localPosition = CalculatePlatformPosition(platformCount);

        CilynderRoot.localScale = new Vector3(1, platformCount * Distance + ExtraCilynderScale, 1);
    }

    private Vector3 CalculatePlatformPosition(int i)
    {
        return new Vector3(0, -Distance * i, 0);
    }
}
