using Godot;

public class GemSoundPlayer : AudioStreamPlayer
{
    private AudioStreamPlayer _player;

    private static GemSoundPlayer _instance;

    public GemSoundPlayer()
    {
        _instance = this;
    }

    public static void PlaySound()
    {
        _instance.PitchScale = 1 + ((GD.Randf() - 0.5f) * 0.1f);
        _instance.Play();
    }
}