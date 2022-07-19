using UnityEngine;

namespace PlayerPrefsVars
{
    public abstract class PlayerPrefsVar<T>
    {
        private readonly string _key;
        private readonly bool _autoSave;

        public T Value
        {
            get => Get(_key);
            set
            {
                Set(_key, value);

                if (_autoSave)
                {
                    PlayerPrefs.Save();
                }
            }
        }

        protected PlayerPrefsVar(string key, bool autoSave = false)
        {
            _key = key;
            _autoSave = autoSave;
        }

        protected abstract T Get(string key);
        protected abstract void Set(string key, T value);
    }
}