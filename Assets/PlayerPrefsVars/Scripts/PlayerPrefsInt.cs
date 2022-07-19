using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsInt : PlayerPrefsVar<int>
    {
        private readonly int _defaultValue;

        public PlayerPrefsInt(string key, int defaultValue = 0, bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override int Get(string key)
        {
            return PlayerPrefs.GetInt(key, _defaultValue);
        }

        protected override void Set(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }
    }
}