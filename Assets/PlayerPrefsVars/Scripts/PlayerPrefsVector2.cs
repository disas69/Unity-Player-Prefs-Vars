using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsVector2 : PlayerPrefsVar<Vector2>
    {
        private readonly Vector2 _defaultValue;

        public PlayerPrefsVector2(string key, Vector2 defaultValue, bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override Vector2 Get(string key)
        {
            return Parse(PlayerPrefs.GetString(key, _defaultValue.ToString()));
        }

        protected override void Set(string key, Vector2 value)
        {
            PlayerPrefs.SetString(key, value.ToString());
        }

        private static Vector2 Parse(string vector)
        {
            var split = vector.Substring(1, vector.Length - 2).Split(',');
            var result = new Vector2(float.Parse(split[0]), float.Parse(split[1]));

            return result;
        }
    }
}