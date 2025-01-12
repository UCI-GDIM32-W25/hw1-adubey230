using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
      _plantCountUI.UpdateSeeds(5, 0);
      _numSeedsLeft = _numSeeds;
      _numSeedsPlanted = 0;
    }

    private void Update()
    {
      if (Input.GetKey(KeyCode.W)) 
      {
        _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
      } 
      if (Input.GetKey(KeyCode.A))
      {
        _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.S))
      {
        _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.D))
      {
        _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
      }

      PlantSeed();
    }

    public void PlantSeed ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_numSeedsLeft > 0 && Input.GetKey(KeyCode.Space))
            {
                GameObject plant = Instantiate(_plantPrefab);
                plant.transform.position = _playerTransform.position;
                _numSeedsLeft -= 1;
                _numSeedsPlanted += 1;
                _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            }
        }
    }
}
