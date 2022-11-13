using Godot;

public class EnemyImage : Sprite
{
    [Export] Texture MadImage = null;
    [Export] Texture SadImage = null;

    public override void _PhysicsProcess(float delta)
    {
        base._PhysicsProcess(delta);

        if (GlobalPosition.x < 260)
        {
            Texture = SadImage;
        }
        else
        {
            Texture = MadImage;
        }
    }
}
