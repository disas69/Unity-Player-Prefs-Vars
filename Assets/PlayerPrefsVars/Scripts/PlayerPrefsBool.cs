using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsBool : PlayerPrefsVar<bool>
    {
        private readonly bool _defaultValue;
    
        public PlayerPrefsBool(string key, bool defaultValue = false, bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override bool Get(string key)
        {
            return PlayerPrefs.GetInt(key, _defaultValue ? 1 : 0) == 1;
        }

        protected override void Set(string key, bool value)
        {
            PlayerPrefs.SetInt(key, value ? 1 : 0);
        }
    }
}