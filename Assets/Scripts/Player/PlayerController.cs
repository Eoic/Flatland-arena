using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private int _speed;

    private void Update() {
        var direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += (direction.normalized * Time.deltaTime * _speed);
    }

    private void OnDrawGizmos() {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        var direction = (mousePosition - transform.position).normalized * 100;
        Debug.DrawRay(transform.position, direction, Color.red);
    }
}
