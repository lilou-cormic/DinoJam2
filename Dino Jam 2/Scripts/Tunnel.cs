using Godot;

public class Tunnel : DestroyHorizontal
{
    public Tunnel()
    {
        Width = 630;
        Multiplier = 2;
    }

    protected override void ManageReachedLimit()
    {
        TunnelFactory.InstantiateTunnel(GlobalPosition + Vector2.Right * Width * Multiplier);

        base.ManageReachedLimit();
    }
}
