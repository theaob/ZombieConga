using UnityEngine;
using System.Collections;

public class ZombieSpawnController : MonoBehaviour {

    public GameObject objectToBeSpawned;
    private int currentZombieCount;
    public int maximumZombieCount;

	// Use this for initialization
	void Start () {
        currentZombieCount = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentZombieCount < maximumZombieCount)
        {
            GameObject.Instantiate(objectToBeSpawned);
            currentZombieCount++;
        }
	}
}
