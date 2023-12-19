using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool hasCoin = false;

    [SerializeField] private Transform pickupTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickupCoin(Transform coinToPickup)
    {
        coinToPickup.position = pickupTransform.position;
        coinToPickup.SetParent(pickupTransform);
        hasCoin = true;

    }

    public bool HasCoin()
    {
        return hasCoin;
    }
}
