using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player player;
    public Transform FinishPlatform;
    public Slider Slider;

    private float _startY;
    private float _minimumReachedY;
    private float FinishDistance = 1f;

    private void Start()
    {
        _startY = player.transform.position.y;
    }

    private void Update()
    {
        _minimumReachedY = Mathf.Min(_minimumReachedY, player.transform.position.y);
        float finishY = FinishPlatform.transform.position.y;
        float t = Mathf.InverseLerp(_startY, finishY + FinishDistance, _minimumReachedY);
        Slider.value = t;
    }
}
