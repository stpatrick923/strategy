using UnityEngine;
using System.Collections;

public class Upgrade_Speed : MonoBehaviour {
	
	public int baseCost = 750;
	public double costPerLevelMultiplier = 2.5;
	public double speedIncreasePerLevel = 1.5;
	private int upgradeLevel = 0;
	private double cost;
	
	// Use this for initialization
	void Start () {
		calculateCost();
	}
	
	// Update is called once per frame
	void Update () {
		// increase the speed of this ship by an amount proportional to the upgrade level
		//this.speed += upgradeLevel * speedIncreasePerLevel;
	}
	
	// try to purchase this upgrade
	bool purchase()
	{
		/*if (hasEnoughMoney) {
		 * 	player.money -= cost
		 *  upgradeLevel++;
		 * 	calculateCost();
		 * 	return true;
		 * }
		 * else {
		 * 	return false;
		 * } 						*/
		return true;
	}
	
	// calculate the cost of this upgrade
	double calculateCost()
	{
		return this.cost = baseCost + upgradeLevel * costPerLevelMultiplier;
	}
}
