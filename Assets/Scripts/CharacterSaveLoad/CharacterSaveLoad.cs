using System;
using System.IO;
using UnityEngine;
using System.Collections.Generic;

namespace CharacterSaveLoad
{
    public class CheckFile
    {
        static string _dir;
        public string _fileDir;

        public CheckFile()
        {
            _dir = string.Join("", Application.dataPath, "/Resources/CharactersConfig/");
            _fileDir = string.Join("", _dir, "characterConfig");
        }

        public void CreateIfDoesNotExist()
        {
            if (Resources.Load<TextAsset>("CharactersConfig/characterConfig") == null)
                File.Create(_dir + "characterConfig.json");
        }

        public TextAsset getFileAsset() => Resources.Load<TextAsset>("CharactersConfig/characterConfig");

        public string getFileDir() => _fileDir + ".json";
    }


    public class CharacterSave {
        JSONDataTemplate toSave;

        public void SaveCharacter(string path, TextAsset file, string name, int initiative, int dexModifier)
        {
            JSONData characters = JsonUtility.FromJson<JSONData>(file.text);
            toSave = new JSONDataTemplate();


            toSave.name = name;
            toSave.initiative = initiative;
            toSave.dexModifier = dexModifier;

            if(characters == null)
            {
                characters = new JSONData();
                characters.data = new List<JSONDataTemplate>();
                toSave.id = 1;
                characters.data.Add(toSave);
            } else
            {
                if(characters.data.Find(x => x.name == name) != null)
                {
                    toSave.id = characters.data.Find(x => x.name == name).id;
                    characters.data[characters.data.FindIndex(x => x.name == name)] = toSave;
                } else
                {
                    toSave.id = characters.data[characters.data.Count - 1].id + 1;
                    characters.data.Add(toSave);
                }
            }

            File.WriteAllText(path, JsonUtility.ToJson(characters));
        }
    }

    public class CharacterLoad
    {
        public JSONData LoadCharacters(TextAsset path)
        {
            return JsonUtility.FromJson<JSONData>(path.text);
        }
    }

    public static class CharacterSaveLoad
    {
            static CheckFile cf = new CheckFile();
            static CharacterSave cs = new CharacterSave();
            static CharacterLoad cl = new CharacterLoad();

        public static void SaveCharacter(string name, int initiative, int dexModifier)
        {
            cf.CreateIfDoesNotExist();
            cs.SaveCharacter(cf.getFileDir(), cf.getFileAsset(), name, initiative, dexModifier); 
        }
        //public static void LoadCharacters() => cl.LoadCharacters(cf.getFileAsset());

    }







    [System.Serializable]
    public class JSONData
    {
        public List<JSONDataTemplate> data;
    }

    [System.Serializable]
    public class JSONDataTemplate
    {
        public int id;
        public string name;
        public int initiative;
        public int dexModifier;
    }
}