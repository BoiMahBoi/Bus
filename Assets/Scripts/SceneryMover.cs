using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryMover : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position -= (transform.right) * Time.deltaTime * 2;
    }
}
