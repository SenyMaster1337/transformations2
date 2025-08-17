using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _targetScale = 3.0f;
    private Vector3 _initialScale;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _initialScale * _targetScale, _speed * Time.deltaTime);
    }
}
