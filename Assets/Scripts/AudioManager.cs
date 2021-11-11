using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
    {
        #region Private_variables
        private AudioSource audioSource;
        #endregion

        #region Public_variables
        public static AudioManager instance;
        public List<SoundData> soundData = new List<SoundData>();
        #endregion

        #region MONOBEHAVIOUR
        void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(this.gameObject);

            this.gameObject.AddComponent<AudioSource>();
            audioSource = this.gameObject.GetComponent<AudioSource>();
            audioSource.playOnAwake = false;
            audioSource.loop = false;
            PlayMusic(Sfx.BgMusic, true);
            //DontDestroyOnLoadManager.DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(this.gameObject);

        }
        private void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        private void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
        
        #endregion
        
        #region Private Methods

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            // if(!scene.name.Contains("HidingOut"))
            // {
            //     Destroy(this.gameObject);
            // }
            Debug.Log("hello");
        }

        #endregion

        #region Public Methods
        public void PlaySoundClip(Sfx _sfx, AudioSource a_src)
        {
            // if (PlayerPrefs.GetInt("IsSound") == 0)
            {
                a_src.volume = soundData[(int)_sfx].volume;
                a_src.pitch= soundData[(int)_sfx].pitch;
                // a_src.PlayOneShot(soundData[(int)_sfx].audioClip);
                a_src.clip = soundData[(int)_sfx].audioClip;
                a_src.Play(0);
            }
        }

        public void StopSoundClip(Sfx _sfx, AudioSource a_src)
        {
            // if (PlayerPrefs.GetInt("IsSound") == 0)
            {
                a_src.Stop();
            }
        }

        public void PlayMusic(Sfx _sfx, bool _isLoop)
        {
            if (PlayerPrefs.GetInt("IsMusic") == 0)
            {
                audioSource.clip = soundData[(int)_sfx].audioClip;
                audioSource.loop = _isLoop;
                audioSource.volume = .5f;
                audioSource.Play();
            }
            else
            {
                StopMusic();
            }
        }
        public void StopMusic()
        {
            audioSource.Stop();
        }

        #endregion

    }
