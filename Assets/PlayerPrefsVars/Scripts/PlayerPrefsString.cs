using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsString : PlayerPrefsVar<string>
    {
        private readonly string _defaultValue;

        public PlayerPrefsString(string key, string defaultValue = "", bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override string Get(string key)
        {
            return PlayerPrefs.GetString(key, _defaultValue);
        }

        protected override void Set(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }
    }
}