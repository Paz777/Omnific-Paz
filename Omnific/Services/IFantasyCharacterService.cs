﻿using Omnific.Model;

namespace Omnific.Services
{
    public interface IFantasyCharacterService
    {
        public FantasyCharacter? CreateNewFantasyCharacter(
            string name, double height, double weight, string habitat, string description, string picture, string APIKeyInventor, string powers);
        public FantasyCharacter? DeleteFantasyCharacterById(int id);
        public List<FantasyCharacter> GetFantasyCharacterByAPIKeyInventor(string APIKeyInventor);
        public FantasyCharacter? GetFantasyCharacterById(int id);
        public List<FantasyCharacter> GetFantasyCharacterByName(string name);
        public FantasyCharacter? UpdateFantasyCharacterById(int idFantasyCharacterToUpdate,
            string newName, double newHeight, double newWeight, string newHabitat,
            string newDescription, string newPicture, string APIKeyInventor, string newPowers);
        public List<FantasyCharacter> GetAllFantasyCharacter();
    }
}