using UnityEngine;
using System.Collections.Generic;

public class SpellManager : MonoBehaviour
{

    public Spell primarySpell;
    public Spell.SpellConnector connector;
    public Spell secondarySpell;

    public Dictionary<string, Spell> spellDictionary = new Dictionary<string, Spell>();

    private void Start()
    {
        // Na primer: "Fire_And_Air"
        Spell[] allSpells = Resources.LoadAll<Spell>("Assets/_Scripts/Spells/_SpellBook"); 
        foreach (Spell spell in allSpells)
        {
            string key = spell.spellType.ToString();
            if (spell.connector != Spell.SpellConnector.None)
            {
                key += "_" + spell.connector.ToString() + "_" + spell.secondarySpellType.ToString();
            }
            spellDictionary.Add(key, spell);
        }
    }

    public Spell GetCombinedSpell()
    {
        string key = primarySpell.spellType.ToString();
        if (connector != Spell.SpellConnector.None)
        {
            key += "_" + connector.ToString() + "_" + secondarySpell.spellType.ToString();
        }

        if (spellDictionary.TryGetValue(key, out Spell combinedSpell))
        {
            return combinedSpell;
        }

        return null; 
    }

    public void CastSpell()
    {
        Spell spellToCast = GetCombinedSpell();
        if (spellToCast != null)
        {

        }
    }

}
