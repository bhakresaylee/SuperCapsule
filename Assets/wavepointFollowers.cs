using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavepointFollowers : MonoBehaviour
{
   [SerializeField] GameObject[] wavepoints;
   int currentWavepointIndex =0;

   [SerializeField] float speed = 1f;
    void Update()
    {
        if(Vector3.Distance(transform.position, wavepoints[currentWavepointIndex].transform.position) < .1f)
        {
            currentWavepointIndex++;
            if(currentWavepointIndex >= wavepoints.Length)
            {
                currentWavepointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wavepoints[currentWavepointIndex].transform.position, speed * Time.deltaTime);
    }
}
