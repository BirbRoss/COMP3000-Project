using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAndFire : MonoBehaviour
{
    [Header("Tennis machine control")]
    [SerializeField] Vector3 center = new Vector3(0.0f, 0.0f, 0.0f);
    public float difficulty = 17.0f;
    float nextSwap = 5f;
    public bool clockwise = true;

    [Header("Ball spawn effect")]
    public GameObject[] ballPool;
    [SerializeField] Transform ballSpawn;

    [Header("Ball instantiation")]
    [SerializeField] GameObject ballPrefab;
    [SerializeField] Transform tennisShooter;
    float nextFire = 3.0f;

    void Update()
    {
        //Controls the direction of the shooter's orbit and where it is looking 
        if (clockwise)
        {
            transform.RotateAround(center, Vector3.up, difficulty * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(center, -Vector3.up, difficulty * Time.deltaTime);
        }    
        transform.LookAt(center);

        //Decides when to swap at a random point
        //Increases difficulty when it swaps, this increases the speed of the shooter and tennis balls
        if (Time.time > nextSwap)
        {
            nextSwap = Random.Range(5.0f, 10.0f) + Time.time;
            clockwise = !clockwise;
            difficulty = difficulty + 2.0f;
        }

        if (Time.time > nextFire)
        {
            nextFire = (Random.Range(4.7f, 6.7f) - (difficulty/10)) + Time.time;
            Shoot();
        }
    }

    void Shoot()
    {
        int rng = Random.Range(0, ballPool.Length);
        ballFade(rng);

        //Could be renabled for large rooms, would not recommend with objects around
        //float angleRng = Random.Range(0.0f, -1.0f);
        //Quaternion launchAngle = new Quaternion(transform.rotation.x + angleRng, transform.rotation.y, transform.rotation.z, transform.rotation.w);

        Instantiate(ballPrefab, tennisShooter.position, transform.rotation);
    }

    void ballFade(int poolNumber)
    {
        //Plays fade in animation on the balls in the basket to make it look like they're being fired out and replenished at ranodom
        ballPool[poolNumber].transform.position = ballSpawn.position;
        ballPool[poolNumber].GetComponent<Animator>().Play("fadeIn");
        
    }
}
