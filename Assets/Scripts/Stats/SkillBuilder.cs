using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBuilder {

	public SkillBuilder() {}

	public Skill Build(StatsEnums.Skill type) {

		if (StatsEnums.Skill.Brawl == type) 
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.Brawl == type)
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.HandWeapon == type)
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.HeavyGuns == type)
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.Throwing == type)
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.Muscles == type)
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.Stealth == type)
			return new Skill (0, StatsEnums.Attribute.CONDITION);
		else if (StatsEnums.Skill.Stealth == type)
			return new Skill (0, StatsEnums.Attribute.PERCEPTION);
		else if (StatsEnums.Skill.Guns == type)
			return new Skill (0, StatsEnums.Attribute.PERCEPTION);
		else if (StatsEnums.Skill.Observation == type)
			return new Skill (0, StatsEnums.Attribute.PERCEPTION);
		else if (StatsEnums.Skill.Listening == type)
			return new Skill (0, StatsEnums.Attribute.PERCEPTION);
		else if (StatsEnums.Skill.Survival == type)
			return new Skill (0, StatsEnums.Attribute.PERCEPTION);
		else if (StatsEnums.Skill.Pickpocket == type)
			return new Skill (0, StatsEnums.Attribute.PERCEPTION);
		else if (StatsEnums.Skill.Lockpicks == type)
			return new Skill (0, StatsEnums.Attribute.INTELIGENCE);
		else if (StatsEnums.Skill.FirstAid == type)
			return new Skill (0, StatsEnums.Attribute.INTELIGENCE);
		else if (StatsEnums.Skill.Medicine == type)
			return new Skill (0, StatsEnums.Attribute.INTELIGENCE);
		else if (StatsEnums.Skill.Repair == type)
			return new Skill (0, StatsEnums.Attribute.INTELIGENCE);
		else if (StatsEnums.Skill.Explosives == type)
			return new Skill (0, StatsEnums.Attribute.INTELIGENCE);
		else if (StatsEnums.Skill.Knowladge == type)
			return new Skill (0, StatsEnums.Attribute.INTELIGENCE);
		else if (StatsEnums.Skill.NervesOfSteel == type)
			return new Skill (0, StatsEnums.Attribute.CHARISMA);
		else if (StatsEnums.Skill.PainResistance == type)
			return new Skill (0, StatsEnums.Attribute.CHARISMA);
		else if (StatsEnums.Skill.Persuasion == type)
			return new Skill (0, StatsEnums.Attribute.CHARISMA);
		else if (StatsEnums.Skill.Intimidation == type)
			return new Skill (0, StatsEnums.Attribute.CHARISMA);
		else if (StatsEnums.Skill.Bluff == type)
			return new Skill (0, StatsEnums.Attribute.CHARISMA);
		else if (StatsEnums.Skill.Taming == type)
			return new Skill (0, StatsEnums.Attribute.CHARISMA);
		else
			return new Skill (0, StatsEnums.Attribute.CHARISMA);	// Here we shall never be, but without this will be error.
	}
}
