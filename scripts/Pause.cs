using Godot;

public partial class Pause : RichTextLabel
{
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_cancel"))
		{
			GD.Print("Pausing Game");
		
			if (Visible)
			{
				Hide();
				GetTree().Paused = false;
			}
			else
			{
				Show();
				GetTree().Paused = true;
			}
		}
	}
}
