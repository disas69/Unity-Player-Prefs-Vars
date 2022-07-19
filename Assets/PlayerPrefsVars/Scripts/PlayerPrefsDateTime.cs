using System;
using System.Globalization;
using UnityEngine;

namespace PlayerPrefsVars
{
    public class PlayerPrefsDateTime : PlayerPrefsVar<DateTime>
    {
        private readonly DateTime _defaultValue;
    
        public PlayerPrefsDateTime(string key, DateTime defaultValue, bool autoSave = false) : base(key, autoSave)
        {
            _defaultValue = defaultValue;
        }

        protected override DateTime Get(string key)
        {
            var value = PlayerPrefs.GetString(key, string.Empty);
            if (string.IsNullOrEmpty(value))
            {
                Set(key, _defaultValue);
            }
        
            if (DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
            {
                return result;
            }
        
            return _defaultValue;
        }

        protected sealed override void Set(string key, DateTime value)
        {
            PlayerPrefs.SetString(key, value.ToString(CultureInfo.InvariantCulture));
        }
    }
}