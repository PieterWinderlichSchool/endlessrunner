using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour 
{
	[SerializeField]
	private LevelChunk[] _chunks;

	[SerializeField]
	private float _spawnThreshold;
    
    [SerializeField]
    private float _bgThreshold;

    //added: background chunk
    [SerializeField]
    private BGChunk[] _bg;

    private Transform _player;
	private LevelChunk _currentChunk;
    //added
    private BGChunk _bgChunk;

    //added
    

	private void Awake()
	{
		_player = GameObject.FindWithTag("Player").transform;
	}

	private void Start()
	{
		_currentChunk = FindObjectOfType<LevelChunk>();
        _bgChunk = FindObjectOfType<BGChunk>();
        
	}

	private void Update()
	{
     	if (_spawnThreshold > _player.position.x) return;

		SpawnChunk();

        if (_bgThreshold > _player.position.x) return;

        SpawnBG();
    }

	void SpawnChunk()
	{
		LevelChunk newChunk = _chunks[Random.Range(0, _chunks.Length)];
		Vector3 spawnPosition = new Vector3((_currentChunk.Position.x + _currentChunk.Size.x / 2f) + (newChunk.Size.x / 2f) + 5,
			_currentChunk.Position.y,
			_currentChunk.Position.z);
		_currentChunk = Instantiate(newChunk, spawnPosition, Quaternion.identity);
		_spawnThreshold += newChunk.Size.x;

		_currentChunk.transform.SetParent(transform);
	}

    void SpawnBG()
    {
        BGChunk newBG = _bg[Random.Range(0, _bg.Length)];
        Vector3 spawnPosition = new Vector3((_bgChunk.Position.x + 40.5f) + (newBG.Size.x / 2f) + 0,
                _bgChunk.Position.y,
                _bgChunk.Position.z);

        _bgChunk = Instantiate(newBG, spawnPosition, Quaternion.identity);
        _spawnThreshold += newBG.Size.x;

        _bgChunk.transform.SetParent(transform);
    }

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(new Vector3(_spawnThreshold, -5, 0), new Vector3(_spawnThreshold, 5, 0));
	}
}
