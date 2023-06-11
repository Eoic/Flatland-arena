using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private int speed;
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _velocity;
    [SerializeField] private float _smoothTime;

    private void LateUpdate() {
        var newPosition = new Vector3(_target.position.x, _target.position.y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref _velocity, _smoothTime);
    }
}
