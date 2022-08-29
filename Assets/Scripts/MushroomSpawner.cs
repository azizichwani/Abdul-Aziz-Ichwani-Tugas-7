using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    //public GameObject objPrefab;
    [SerializeField] private GameObject _mushroom;
    [SerializeField] private int _maxMushroom = 20;
    [SerializeField] private List<GameObject> _mushroomSpawned;

    private float timer;

    private void Awake()
    {
        _mushroomSpawned = new List<GameObject>();
    }

    private void Start()
    {
        for (int i = 0; i < _maxMushroom; i++)
        {
            GameObject mushroom = Instantiate(_mushroom, transform.position, Quaternion.identity, transform);
            mushroom.SetActive(false);
            _mushroomSpawned.Add(mushroom);
        }
    }

    void FixedUpdate(){
        //Instantiate(objPrefab, transform.position, Quaternion.identity);

        SpawnMushroomPool();
    }

    public void SpawnMushroomPool()
    {
        GameObject mushroomPool = MushroomPool();
        timer += Time.deltaTime;
        if(timer > 0.3)
        {
            if(mushroomPool != null)
            {
                mushroomPool.transform.position = this.transform.position;
                mushroomPool.SetActive(true);
            }
            timer = 0;
        }
    }

    public GameObject MushroomPool()
    {
        for ( int  i = 0; i < _mushroomSpawned.Count; i++ )
        {
            if(!_mushroomSpawned[i].activeInHierarchy)
            {
                return _mushroomSpawned[i];
            }
        }
        return null;
    }
}
