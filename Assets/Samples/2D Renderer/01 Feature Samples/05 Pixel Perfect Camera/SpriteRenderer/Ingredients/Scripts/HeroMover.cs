using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelPerfectSpriteRendererSample
{
public class HeroMover : MonoBehaviour
{
    public float Amplitude = 1.0f;
    public float Frequency = 1.0f;

    private Vector3 origin;
    private float offset;

    void Start()
    {
        origin = transform.position;
    }

    void Update()
    {
        offset = Mathf.Sin(Time.time * Frequency * 4.0f) * Amplitude;
        transform.position = origin + Vector3.right * offset;
    }
}
}
