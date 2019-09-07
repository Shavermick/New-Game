using UnityEngine;

public class Hero : SelectCharacterHero
{
	[Header("Name Hero")]
	public string nameHero;

	[Header("Hp Hero")]
	public int maxHp;
	private int currentHp;

	public int CurrentHp
	{
		get {
			return currentHp;
		}
		set {
			if (currentHp < 0)
			{
				currentHp = 0;
			}
			currentHp = value;
		}
	}

	[Header("Mp Hero")]
	public int maxMp;
	private int currentMp;

	public int CurrentMp
	{
		get {
			return currentMp;
		}
		set {
				if (currentMp < 0)
				{
					currentMp = 0;
				}
			currentMp = value;
			}
	}


	public int Agility { get; set; }
	public int Strength { get; set; }
	public int Intellect { get; set; }
	public int Vitality { get; set; }

	public int minPhysicAttack;
	public int maxPhysicAttack;

	public int minMagicAttack;
	public int maxMagicAttack;

	public int PhysicDefend;
	public int MagicDefend;

	Hero hero;
	
    void Start()
    {
		nameHero = hero.nameHero;

		maxHp = hero.maxHp;
		CurrentHp = maxHp;

		maxMp = hero.maxMp;
		CurrentMp = maxMp;

		Agility = hero.Agility;
		Strength = hero.Strength;
		Intellect = hero.Intellect;
		Vitality = hero.Vitality;

		minPhysicAttack = hero.minPhysicAttack;
		maxPhysicAttack = hero.maxPhysicAttack;

		minMagicAttack = hero.minMagicAttack;
		maxMagicAttack = hero.maxMagicAttack;

		PhysicDefend = hero.PhysicDefend;
		MagicDefend = hero.MagicDefend;
	}
	
    void Update()
    {
        
    }
}
