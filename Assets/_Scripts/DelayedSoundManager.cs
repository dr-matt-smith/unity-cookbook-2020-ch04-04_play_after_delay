using UnityEngine;

public class DelayedSoundManager : MonoBehaviour
{
    public AudioSource audioSourcePacmandMusic;
    public AudioSource audioSourceDies;

    public void ACTION_PlayMusicNow()
    {
        audioSourcePacmandMusic.Play();
    }

    public void ACTION_PlayDiesSoundAfterDelay()
    {
        float delay = 1.0F;
        audioSourceDies.PlayDelayed(delay);
    }
}
