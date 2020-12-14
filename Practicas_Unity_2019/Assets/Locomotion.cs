using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    public Transform player;
    public Vector3 heightOffset;
    // Start is called before the first frame update
    public void TeleportPlayer(Vector3 newPosition)
    {
        player.position = newPosition + heightOffset;
    }
}
