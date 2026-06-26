using Godot;
using System;

public partial class ButtonUp : TextureButton
{
	//[Export] public NodePath LabelPath;
	//private Label water_label;
	//private int water_amount;
	
	public override void _Ready()
	{
		//water_label = GetNode<Label>($"../../WaterLabel");
		Pressed += ButtonPressed;
	}
	
	private void ButtonPressed()
	{
		//water_amount += 1;
		//water_label.Text = "Water today: " + water_amount;
		
		GD.Print("Up arrow has been pressed.");
	}
}
