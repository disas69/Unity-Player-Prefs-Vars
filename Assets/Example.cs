using System;
using PlayerPrefsVars;
using UnityEngine;
using Random = UnityEngine.Random;

public class Example : MonoBehaviour
{
    private readonly PlayerPrefsInt _count = new PlayerPrefsInt("TEST_INT", 0, true);
    private readonly PlayerPrefsBool _flag = new PlayerPrefsBool("TEST_BOOL", false, true);
    private readonly PlayerPrefsFloat _stat = new PlayerPrefsFloat("TEST_FLOAT", 0f, true);
    private readonly PlayerPrefsString _message = new PlayerPrefsString("TEST_STRING", "Hello World", true);
    private readonly PlayerPrefsVector2 _direction2D = new PlayerPrefsVector2("TEST_VECTOR2", Vector2.zero, true);
    private readonly PlayerPrefsVector3 _direction3D = new PlayerPrefsVector3("TEST_VECTOR3", Vector3.zero, true);
    private readonly PlayerPrefsDateTime _date = new PlayerPrefsDateTime("TEST_DATETIME", DateTime.Now, true);

    [SerializeField] private bool _increment; 

    public void Awake()
    {
        if (_increment)
        {
            _count.Value++;
            _flag.Value = !_flag.Value;
            _stat.Value += Random.value;
            _message.Value += " Hello!";
            _direction2D.Value = Vector2.one * Random.value;
            _direction3D.Value = Vector3.one * Random.value;
            _date.Value += TimeSpan.FromMinutes(10d);
        }

        Debug.Log($"Count: {_count.Value}");
        Debug.Log($"Flag: {_flag.Value}");
        Debug.Log($"Stat: {_stat.Value}");
        Debug.Log($"Message: {_message.Value}");
        Debug.Log($"Direction 2D: {_direction2D.Value}");
        Debug.Log($"Direction 3D: {_direction3D.Value}");
        Debug.Log($"Date: {_date.Value}");
    }
}