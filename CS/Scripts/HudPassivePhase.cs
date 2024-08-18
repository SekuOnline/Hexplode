using Godot;
using System;

public partial class HudPassivePhase : CanvasLayer
{

	//Make 'gold' a pointer to the PlayerData object.
	int gold;
	Label goldLabel;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var phaseButton = GetNode<Button>("PhaseResetButton");
		phaseButton.Pressed += OnButtonPressed;

		goldLabel = GetNode<Label>("GoldLabel");
		gold = 0;
		updateGold(10);
		GD.Print("HUD Ready.");
	}

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}

	private void OnButtonPressed()
    {
        GD.Print("Phase Reset.");
		//Income:
		updateGold(3);
		//Reset Alert(s):
		
    }


	public void updateGold(int addGold)
	{
		gold += addGold;
		goldLabel.Text = "GOLD: "+gold.ToString();
		GD.Print("Updated gold to "+gold.ToString());
	}
}
