using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationBot : MonoBehaviour
{
    [SerializeField] private Unit _botPrefab;
    [SerializeField] private BaseBot _baseBot;

    public Unit SpawnBot(Vector3 randomPosition)
    {
        return Instantiate(_botPrefab, randomPosition, transform.rotation);
    }
}
