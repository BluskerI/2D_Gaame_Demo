using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

public class DemoManager : MonoBehaviour
{
    private PlayerMovement _player;
    [SerializeField] private Tilemap[] levels;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private TextMeshProUGUI nameText;

    private int _currentTilemapIndex;

    private void Start()
    {       
        SwitchLevel(0);        
    }

    public void SwitchLevel(int index)
    {
        levels[_currentTilemapIndex].gameObject.SetActive(false);
        levels[index].gameObject.SetActive(true);
        levels[_currentTilemapIndex] = levels[index];

        //_player.transform.position = spawnPoint.position;

        _currentTilemapIndex = index;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchLevel((_currentTilemapIndex == levels.Length - 1) ? 0 : _currentTilemapIndex + 1);
        }
    }
}
