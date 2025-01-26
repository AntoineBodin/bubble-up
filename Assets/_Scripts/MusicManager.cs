using UnityEngine;
using UnityEngine.Audio;

namespace Assets._Scripts
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        public static MusicManager Instance { get; private set; }

        [Header("Music")]
        public AudioClip backgroundMusic;

        [Header("Sounds")]
        public AudioClip bubblePopSound;
        public AudioClip bubbleInflatingSound;
        public AudioClip bubbleDropSound;
        public AudioClip bubbleMergeSound;

        private AudioSource audioSource;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                audioSource = GetComponent<AudioSource>();
            }
            else
                Destroy(gameObject);
        }

        public void PlaySound(AudioClip sound, float minPitch, float maxPitch, float volume = 1f)
        {
            if (sound == null) return;

            audioSource.pitch = Random.Range(minPitch, maxPitch);
            audioSource.volume = volume;
            audioSource.PlayOneShot(sound);
        }

        public void StartMusic(AudioClip music, float pitch, float volume = 1f)
        {
            if (audioSource.clip == music && audioSource.isPlaying) return;

            audioSource.clip = music;
            audioSource.loop = false;
            audioSource.pitch = pitch;
            audioSource.volume = volume;
            audioSource.Play();
        }

        public void StopMusic()
        {
            audioSource.Stop();
        }
    }
}