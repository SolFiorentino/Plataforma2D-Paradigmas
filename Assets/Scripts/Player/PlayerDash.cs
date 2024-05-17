using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float dashSpeed = 20f;

    public void Dash(float distance)
    {
        Vector3 dashPosition = transform.position + transform.right * distance;
        transform.position = Vector3.Lerp(transform.position, dashPosition, dashSpeed * Time.deltaTime);
    }
}
