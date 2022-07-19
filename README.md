# Unity-Player-Prefs-Vars

A simple PlayerPrefs extension. Includes: int, float, bool, string, Vector2, Vector3, DateTime.

```
    // Pass to the constructor the PlayerPrefs key, a default value and a bool that determines if PlayerPrefs.Save() needs to be called automatically on every change
    
    private readonly PlayerPrefsInt _count = new PlayerPrefsInt("TEST_INT", 0, true);
    private readonly PlayerPrefsBool _flag = new PlayerPrefsBool("TEST_BOOL", false, true);
    private readonly PlayerPrefsFloat _stat = new PlayerPrefsFloat("TEST_FLOAT", 0f, true);
    
    // Read or write to your PlayerPrefs variables by accessing the Value property
    
    _count.Value++;
    _flag.Value = !_flag.Value;
    _stat.Value += Random.value;
```
