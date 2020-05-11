using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ballPrefabArray;
    [SerializeField] float spawnTime = 15f;
    [SerializeField] float spawnDelay = 1f;

    //---Helps to check the color of the new spawned ball
    private GameObject _newBall;

    private Color[] colors = { Color.red, Color.blue, Color.yellow };

    bool _spawn = true;

    //Start is called before the first frame update
    IEnumerator Start()
    {
        while (_spawn)
        {
            yield return new WaitForSeconds(0.2f);
            SpawnBall();
        }
    }

    //private void Start()
    //{
    //    //
    //    //InvokeRepeating("SpawnBall", spawnDelay, spawnTime);
    //    //SpawnBall();
        
    //}

    // Update is called once per frame
    private void Update()
    {
        
        //SpawnBall();
    }

    public void SpawnBall()
    {
        
        //---To get reference of the spawned object
        _newBall = Instantiate(ballPrefabArray, transform.position, Quaternion.identity);
        _newBall.GetComponent<MeshRenderer>().material.color =
            colors[Random.Range(0, colors.Length)];
        //GetBallColor();
        //return _newBall;
        
        
    }

    //---WIP
    public Color GetBallColor()
    {
        Color newColor = _newBall.GetComponent<MeshRenderer>().material.color;
        return newColor;
    }
}
