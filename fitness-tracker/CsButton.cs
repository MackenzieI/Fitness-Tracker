using Godot;
using System;

public partial class CsButton : Button
{
	public override void _Ready()
	{
		Pressed += ButtonPressed;
	}
	
	private void ButtonPressed()
	{
		GD.Print("C&S Button has been pressed.");
		GetTree().ChangeSceneToFile("res://Charts and Statistics.tscn");
	}
}
