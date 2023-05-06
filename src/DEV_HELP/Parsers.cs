namespace DEV_HELP
{
  public class Parsers
  {
    string[] values = {
      "        Name = \"{0}\",",
      "        Level = {0},",
      "        Class = \"\",",
      "        School = \"{0}\",",
      "        CastingTime = \"{0}\",",
      "        Range = \"{0}\",",
      "        Components = \"{0}\",",
      "        Duration = \"{0}\",",
      "        Description = {0},",
      "        Ritual = {0}"
    };


    public void SpellParser()
    {
      List<string> formattedFile = new List<string>
      {
        "    internal static readonly List<Spell> Spells = new()",
        "    {"
      };

      string[] array = Directory.GetFiles(@"C:\Users\chase\Documents\Code\DnD-Character-Sheet\Data\Spells\PHB\", "message*.txt");
      string[] lines = File.ReadAllLines(array[0]);
      for (int i = 1; i < array.Length; i++)
      {
        lines = lines.Concat(File.ReadAllLines(array[i]).ToList()).ToArray();
      }
      //string[] lines = File.ReadAllLines(@"C:\Users\chase\Downloads\message.txt");

      bool firstSpell = true;
      int spellMakerCount = 0;
      bool ritualSpell = false;
      string description = string.Empty;
      string spellRegionLetter = "";
      for (int index = 0; index < lines.Length; index++)
      {
        if (string.IsNullOrEmpty(lines[index]))
        {
          if (spellMakerCount != 8)
          {
            spellMakerCount++;
          }
          continue;
        }
        if (lines[index] == "//")
        {
          if (spellMakerCount == 8)
          {
            // END OF DESCRIPTION
            formattedFile.Add(string.Format(values[spellMakerCount], description));
            description = string.Empty;
            spellMakerCount += 1;
            formattedFile.Add(string.Format(values[spellMakerCount], ritualSpell.ToString().ToLower()));
          }


          if (!firstSpell)
          {
            formattedFile.Add("      },");
          }

          string tempChar = lines[index + 1][0].ToString();

          if (tempChar.ToUpper() != spellRegionLetter)
          {
            if (!firstSpell)
            {
              formattedFile.Add("      #endregion " + spellRegionLetter + " Spells");
              formattedFile.Add("      ");
            }
            formattedFile.Add("      #region " + tempChar + " Spells");
            spellRegionLetter = tempChar;
          }

          formattedFile.Add("      new Spell");
          formattedFile.Add("      {");
          spellMakerCount = 0;
          firstSpell = false;
          continue;
        }

        // Level, School and Ritual
        if (spellMakerCount == 1)
        {
          string[] splitString = lines[index].Split(" ");

          if (splitString.Length >= 2) // No Ritual
          {
            ritualSpell = false;
            string first = splitString[0][0].ToString();

            string second = splitString[1];
            if (splitString[1].ToLower() == "cantrip")
            {
              first = "0";
              second = splitString[0];
            }

            second = second[0].ToString().ToUpper() + second.Substring(1);

            // Level | 1
            formattedFile.Add(string.Format(values[spellMakerCount], first));
            // Class | 2
            spellMakerCount += 1;
            formattedFile.Add(values[spellMakerCount]);
            // School| 3
            spellMakerCount += 1;
            formattedFile.Add(string.Format(values[spellMakerCount], second));
            if (splitString.Length == 3)
            {
              ritualSpell = true;
            }
          }
          continue;
        }

        if (spellMakerCount == 8)
        {
          if (!string.IsNullOrEmpty(description))
          {
            description += " + " + Environment.NewLine;
          }
          description += "\"" + lines[index] + "\"";
          continue;
        }

        formattedFile.Add(string.Format(values[spellMakerCount], lines[index]));
        if (spellMakerCount == 0)
        {
          spellMakerCount++;
        }
      }


      // END OF FILE
      formattedFile.Add(string.Format(values[spellMakerCount], description));
      description = string.Empty;
      spellMakerCount += 1;
      formattedFile.Add(string.Format(values[spellMakerCount], ritualSpell.ToString().ToLower()));
      formattedFile.Add("      }");
      formattedFile.Add("      #endregion " + spellRegionLetter + " Spells");
      formattedFile.Add("    };");
      File.WriteAllLines(@"C:\Users\chase\Documents\Code\DnD-Character-Sheet\Data\Spells\PHB\OUTPUT.txt", formattedFile);
    }

  }
}