using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsFloat : PlayerPrefsVar<float>
    {
        private readonly float _defaultValue;

        public PlayerPrefsFloat(string key, float defaultValue, bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override float Get(string key)
        {
            return PlayerPrefs.GetFloat(key, _defaultValue);
        }

        protected override void Set(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
        }
    }
}