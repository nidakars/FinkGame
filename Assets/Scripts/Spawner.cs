using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject _hexagonPrefabs;
    public float _spawnRate = 1f;
    private float _newSpawnTime;
    private int level = 0;
    [SerializeField]
    private Text _score;



    // Update is called once per frame
    void Update()
    {
        if(Time.time>=_newSpawnTime)
        {
           
            Instantiate(_hexagonPrefabs, Vector3.zero, Quaternion.identity);
            _newSpawnTime = Time.time + 1f / _spawnRate;
                 level++;
        }
        _score.text ="Score:"+ (level-1).ToString();
    }

    

}
