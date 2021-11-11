using UnityEngine;

public enum Sfx
{
    BgMusic,

    bullet_shoot,
    // bullet_move,
    // bullet_hit,

    rocket_shoot,
    // rocket_move,
    burning,
    rocket_hit,

}

[System.Serializable]
public class SoundData
{
    public Sfx gameSfx;
    public AudioClip audioClip;

    [Range(0f, 1f)]
    public float volume;

    [Range(.3f, 3f)]
    public float pitch;
}