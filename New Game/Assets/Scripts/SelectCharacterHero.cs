using UnityEngine;

public class SelectCharacterHero : MonoBehaviour
{
	static string nameHero;
	static int maxHP;

	static int maxMP;

	static int Agility;
	static int Strength;
	static int Intellect;
	static int Vitality;

	static int minPhysicAttack;
	static int maxPhysicAttack;

	static int minMagicAttack;
	static int maxMagicAttack;

	static int PhysicDefend;
	static int MagicDefend;

	public void SwitchCharacter(GetIdHero Id)
	{
		switch (Id.IdHero)
		{
			#region Sword Hero Characteristic
			case 1:
				{
					nameHero = "";

					maxHP = 0;
					maxMP = 0;

					Agility = 0;
					Strength = 0;
					Intellect = 0;
					Vitality = 0;

					minPhysicAttack = 0;
					maxPhysicAttack = 0;

					minMagicAttack = 0;
					maxMagicAttack = 0;

					PhysicDefend = 0;
					MagicDefend = 0;

					break;
				}
			#endregion

			#region Archer Hero Characteristic
			case 2:
				{
					nameHero = "";

					maxHP = 0;
					maxMP = 0;

					Agility = 0;
					Strength = 0;
					Intellect = 0;
					Vitality = 0;

					minPhysicAttack = 0;
					maxPhysicAttack = 0;

					minMagicAttack = 0;
					maxMagicAttack = 0;

					PhysicDefend = 0;
					MagicDefend = 0;

					break;
				}
			#endregion

			#region 
			case 3:
				{
					maxHP = 0;
					maxMP = 0;

					Agility = 0;
					Strength = 0;
					Intellect = 0;
					Vitality = 0;

					minPhysicAttack = 0;
					maxPhysicAttack = 0;

					minMagicAttack = 0;
					maxMagicAttack = 0;

					PhysicDefend = 0;
					MagicDefend = 0;

					break;
				}
			#endregion
		}
	}
}
