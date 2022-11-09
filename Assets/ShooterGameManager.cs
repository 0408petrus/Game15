using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShooterGameManager : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    // Update is called once per frame
    void Start()
    {
        var randomViewPortPos = new Vector2(
            Random.Range(0.2f, 0.8f),
            Random.Range(0.2f, 0.8f)
            );
        var randomWorldpos = Camera.main.ViewportToWorldPoint(randomViewPortPos);
        randomWorldpos = new Vector3(randomWorldpos.x, randomWorldpos.y, 0);
        PhotonNetwork.Instantiate(playerPrefab.name, randomWorldpos, Quaternion.identity);

    }
}
