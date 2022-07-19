using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsVector3 : PlayerPrefsVar<Vector3>
    {
        private readonly Vector3 _defaultValue;

        public PlayerPrefsVector3(string key, Vector3 defaultValue, bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override Vector3 Get(string key)
        {
            return Parse(PlayerPrefs.GetString(key, _defaultValue.ToString()));
        }

        protected override void Set(string key, Vector3 value)
        {
            PlayerPrefs.SetString(key, value.ToString());
        }

        private static Vector3 Parse(string vector)
        {
            var split = vector.Substring(1, vector.Length - 2).Split(',');
            var result = new Vector3(float.Parse(split[0]), float.Parse(split[1]), float.Parse(split[2]));

            return result;
        }
    }
}