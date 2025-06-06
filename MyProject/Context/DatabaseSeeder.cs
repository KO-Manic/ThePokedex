using MyProject.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Context
{
    public class DatabaseSeeder
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;

        public DatabaseSeeder(DatabaseContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task Seed()
        {
            await _context.Database.MigrateAsync();

            // don't add the user if they already exist
            if (!_context.Users.Any())
            {
                var adminEmail = "ash@pokemon.com";
                var adminPassword = "Misty123!"; // make sure password is complex enough

                var admin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail
                };

                await _userManager.CreateAsync(admin, adminPassword);
            }

            // don't add the pokemon if they already exist
            if (!_context.Pokemons.Any())
            {
                var pokemonList = new List<Pokemon>()
                {
                    new Pokemon
                    {
                        Name = "Bulbasaur", Type = "Grass", Total = 318, HP = 45, Attack = 49, Defence = 49, Speed = 45,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ivysaur", Type = "Grass", Total = 405, HP = 60, Attack = 62, Defence = 63, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Venusaur", Type = "Grass", Total = 525, HP = 80, Attack = 82, Defence = 83, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "VenusaurMega Venusaur", Type = "Grass", Total = 625, HP = 80, Attack = 100,
                        Defence = 123, Speed = 80, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Charmander", Type = "Fire", Total = 309, HP = 39, Attack = 52, Defence = 43, Speed = 65,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Charmeleon", Type = "Fire", Total = 405, HP = 58, Attack = 64, Defence = 58, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Charizard", Type = "Fire", Total = 534, HP = 78, Attack = 84, Defence = 78, Speed = 100,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "CharizardMega Charizard X", Type = "Fire", Total = 634, HP = 78, Attack = 130,
                        Defence = 111, Speed = 100, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "CharizardMega Charizard Y", Type = "Fire", Total = 634, HP = 78, Attack = 104,
                        Defence = 78, Speed = 100, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Squirtle", Type = "Water", Total = 314, HP = 44, Attack = 48, Defence = 65, Speed = 43,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wartortle", Type = "Water", Total = 405, HP = 59, Attack = 63, Defence = 80, Speed = 61,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Blastoise", Type = "Water", Total = 530, HP = 79, Attack = 83, Defence = 100,
                        Speed = 78, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "BlastoiseMega Blastoise", Type = "Water", Total = 630, HP = 79, Attack = 103,
                        Defence = 120, Speed = 78, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Caterpie", Type = "Bug", Total = 195, HP = 45, Attack = 30, Defence = 35, Speed = 45,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Metapod", Type = "Bug", Total = 205, HP = 50, Attack = 20, Defence = 55, Speed = 30,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Butterfree", Type = "Bug", Total = 385, HP = 60, Attack = 45, Defence = 50, Speed = 70,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Weedle", Type = "Bug", Total = 195, HP = 40, Attack = 35, Defence = 30, Speed = 50,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kakuna", Type = "Bug", Total = 205, HP = 45, Attack = 25, Defence = 50, Speed = 35,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Beedrill", Type = "Bug", Total = 395, HP = 65, Attack = 90, Defence = 40, Speed = 75,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "BeedrillMega Beedrill", Type = "Bug", Total = 495, HP = 65, Attack = 150, Defence = 40,
                        Speed = 145, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pidgey", Type = "Normal", Total = 251, HP = 40, Attack = 45, Defence = 40, Speed = 56,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pidgeotto", Type = "Normal", Total = 349, HP = 63, Attack = 60, Defence = 55,
                        Speed = 71, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pidgeot", Type = "Normal", Total = 479, HP = 83, Attack = 80, Defence = 75, Speed = 91,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "PidgeotMega Pidgeot", Type = "Normal", Total = 579, HP = 83, Attack = 80, Defence = 80,
                        Speed = 121, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rattata", Type = "Normal", Total = 253, HP = 30, Attack = 56, Defence = 35, Speed = 82,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Raticate", Type = "Normal", Total = 413, HP = 55, Attack = 81, Defence = 60,
                        Speed = 117, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spearow", Type = "Normal", Total = 262, HP = 40, Attack = 60, Defence = 30, Speed = 72,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Fearow", Type = "Normal", Total = 442, HP = 65, Attack = 90, Defence = 65, Speed = 122,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ekans", Type = "Poison", Total = 288, HP = 35, Attack = 60, Defence = 44, Speed = 49,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Arbok", Type = "Poison", Total = 438, HP = 60, Attack = 95, Defence = 69, Speed = 74,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pikachu", Type = "Electric", Total = 320, HP = 35, Attack = 55, Defence = 40,
                        Speed = 90, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Raichu", Type = "Electric", Total = 485, HP = 60, Attack = 90, Defence = 55, Speed = 90,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sandshrew", Type = "Ground", Total = 300, HP = 50, Attack = 75, Defence = 85,
                        Speed = 40, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sandslash", Type = "Ground", Total = 450, HP = 75, Attack = 100, Defence = 110,
                        Speed = 65, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nidoran♀", Type = "Poison", Total = 275, HP = 55, Attack = 47, Defence = 52, Speed = 41,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nidorina", Type = "Poison", Total = 365, HP = 70, Attack = 62, Defence = 67, Speed = 66,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nidoqueen", Type = "Poison", Total = 505, HP = 90, Attack = 92, Defence = 87,
                        Speed = 76, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nidoran♂", Type = "Poison", Total = 273, HP = 46, Attack = 57, Defence = 40, Speed = 50,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nidorino", Type = "Poison", Total = 365, HP = 61, Attack = 72, Defence = 57, Speed = 75,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nidoking", Type = "Poison", Total = 505, HP = 81, Attack = 102, Defence = 77,
                        Speed = 85, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Clefairy", Type = "Fairy", Total = 310, HP = 70, Attack = 45, Defence = 48, Speed = 35,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Clefable", Type = "Fairy", Total = 483, HP = 95, Attack = 70, Defence = 73, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vulpix", Type = "Fire", Total = 299, HP = 38, Attack = 41, Defence = 40, Speed = 65,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ninetales", Type = "Fire", Total = 505, HP = 73, Attack = 76, Defence = 75, Speed = 100,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Jigglypuff", Type = "Normal", Total = 270, HP = 115, Attack = 45, Defence = 20,
                        Speed = 20, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wigglytuff", Type = "Normal", Total = 435, HP = 140, Attack = 70, Defence = 45,
                        Speed = 40, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zubat", Type = "Poison", Total = 245, HP = 40, Attack = 45, Defence = 35, Speed = 55,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Golbat", Type = "Poison", Total = 455, HP = 75, Attack = 80, Defence = 70, Speed = 105,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Oddish", Type = "Grass", Total = 320, HP = 45, Attack = 50, Defence = 55, Speed = 30,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gloom", Type = "Grass", Total = 395, HP = 60, Attack = 65, Defence = 70, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vileplume", Type = "Grass", Total = 490, HP = 75, Attack = 80, Defence = 85, Speed = 75,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Paras", Type = "Bug", Total = 285, HP = 35, Attack = 70, Defence = 55, Speed = 25,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Parasect", Type = "Bug", Total = 405, HP = 60, Attack = 95, Defence = 80, Speed = 70,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Venonat", Type = "Bug", Total = 305, HP = 60, Attack = 55, Defence = 50, Speed = 40,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Venomoth", Type = "Bug", Total = 450, HP = 70, Attack = 65, Defence = 60, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Diglett", Type = "Ground", Total = 265, HP = 10, Attack = 55, Defence = 25, Speed = 95,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dugtrio", Type = "Ground", Total = 405, HP = 35, Attack = 80, Defence = 50, Speed = 140,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Meowth", Type = "Normal", Total = 290, HP = 40, Attack = 45, Defence = 35, Speed = 70,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Persian", Type = "Normal", Total = 440, HP = 65, Attack = 70, Defence = 60, Speed = 105,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Psyduck", Type = "Water", Total = 320, HP = 50, Attack = 52, Defence = 48, Speed = 55,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Golduck", Type = "Water", Total = 500, HP = 80, Attack = 82, Defence = 78, Speed = 85,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mankey", Type = "Fighting", Total = 305, HP = 40, Attack = 80, Defence = 35, Speed = 50,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Primeape", Type = "Fighting", Total = 455, HP = 65, Attack = 105, Defence = 60,
                        Speed = 85, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Growlithe", Type = "Fire", Total = 350, HP = 55, Attack = 70, Defence = 45, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Arcanine", Type = "Fire", Total = 555, HP = 90, Attack = 110, Defence = 80, Speed = 105,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Poliwag", Type = "Water", Total = 300, HP = 40, Attack = 50, Defence = 40, Speed = 70,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Poliwhirl", Type = "Water", Total = 385, HP = 65, Attack = 65, Defence = 65, Speed = 85,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Poliwrath", Type = "Water", Total = 510, HP = 90, Attack = 95, Defence = 95, Speed = 75,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Abra", Type = "Psychic", Total = 310, HP = 25, Attack = 20, Defence = 15, Speed = 90,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kadabra", Type = "Psychic", Total = 400, HP = 40, Attack = 35, Defence = 30,
                        Speed = 105, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Alakazam", Type = "Psychic", Total = 500, HP = 55, Attack = 50, Defence = 45,
                        Speed = 120, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AlakazamMega Alakazam", Type = "Psychic", Total = 590, HP = 55, Attack = 50,
                        Defence = 65, Speed = 150, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Machop", Type = "Fighting", Total = 305, HP = 70, Attack = 80, Defence = 50, Speed = 35,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Machoke", Type = "Fighting", Total = 405, HP = 80, Attack = 100, Defence = 70,
                        Speed = 55, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Machamp", Type = "Fighting", Total = 505, HP = 90, Attack = 130, Defence = 80,
                        Speed = 55, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bellsprout", Type = "Grass", Total = 300, HP = 50, Attack = 75, Defence = 35,
                        Speed = 40, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Weepinbell", Type = "Grass", Total = 390, HP = 65, Attack = 90, Defence = 50,
                        Speed = 60, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Victreebel", Type = "Grass", Total = 490, HP = 80, Attack = 105, Defence = 65,
                        Speed = 80, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tentacool", Type = "Water", Total = 335, HP = 40, Attack = 40, Defence = 35, Speed = 70,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tentacruel", Type = "Water", Total = 515, HP = 80, Attack = 70, Defence = 65,
                        Speed = 80, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Geodude", Type = "Rock", Total = 300, HP = 40, Attack = 80, Defence = 100, Speed = 20,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Graveler", Type = "Rock", Total = 390, HP = 55, Attack = 95, Defence = 115, Speed = 25,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Golem", Type = "Rock", Total = 495, HP = 80, Attack = 120, Defence = 130, Speed = 65,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ponyta", Type = "Fire", Total = 400, HP = 50, Attack = 85, Defence = 55, Speed = 90,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rapidash", Type = "Fire", Total = 500, HP = 65, Attack = 100, Defence = 70, Speed = 105,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slowpoke", Type = "Water", Total = 315, HP = 90, Attack = 65, Defence = 65, Speed = 15,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slowbro", Type = "Water", Total = 490, HP = 95, Attack = 75, Defence = 110, Speed = 30,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "SlowbroMega Slowbro", Type = "Water", Total = 590, HP = 95, Attack = 85, Defence = 180,
                        Speed = 30, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magnemite", Type = "Electric", Total = 325, HP = 25, Attack = 35, Defence = 70,
                        Speed = 45, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magneton", Type = "Electric", Total = 465, HP = 50, Attack = 60, Defence = 95,
                        Speed = 60, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Farfetch'd", Type = "Normal", Total = 352, HP = 52, Attack = 65, Defence = 55,
                        Speed = 80, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Doduo", Type = "Normal", Total = 310, HP = 35, Attack = 85, Defence = 45, Speed = 145,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dodrio", Type = "Normal", Total = 470, HP = 60, Attack = 110, Defence = 70, Speed = 110,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Seel", Type = "Water", Total = 325, HP = 65, Attack = 45, Defence = 55, Speed = 45,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dewgong", Type = "Water", Total = 475, HP = 90, Attack = 70, Defence = 80, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Grimer", Type = "Poison", Total = 325, HP = 80, Attack = 80, Defence = 50, Speed = 15,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Muk", Type = "Poison", Total = 500, HP = 105, Attack = 105, Defence = 75, Speed = 15,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shellder", Type = "Water", Total = 305, HP = 30, Attack = 65, Defence = 100,
                        Speed = 110, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cloyster", Type = "Water", Total = 525, HP = 50, Attack = 95, Defence = 180, Speed = 70,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Krabby", Type = "Water", Total = 325, HP = 30, Attack = 105, Defence = 90, Speed = 50,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kingler", Type = "Water", Total = 475, HP = 55, Attack = 130, Defence = 115, Speed = 75,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Voltorb", Type = "Electric", Total = 330, HP = 40, Attack = 30, Defence = 50,
                        Speed = 100, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Electrode", Type = "Electric", Total = 480, HP = 60, Attack = 50, Defence = 70,
                        Speed = 100, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Exeggcute", Type = "Grass", Total = 325, HP = 60, Attack = 40, Defence = 80, Speed = 40,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Exeggutor", Type = "Grass", Total = 520, HP = 95, Attack = 95, Defence = 85, Speed = 55,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cubone", Type = "Ground", Total = 320, HP = 50, Attack = 50, Defence = 95, Speed = 35,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Marowak", Type = "Ground", Total = 425, HP = 60, Attack = 60, Defence = 110, Speed = 45,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hitmonlee", Type = "Fighting", Total = 455, HP = 50, Attack = 120, Defence = 53,
                        Speed = 87, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hitmonchan", Type = "Fighting", Total = 455, HP = 50, Attack = 105, Defence = 79,
                        Speed = 71, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lickitung", Type = "Normal", Total = 385, HP = 90, Attack = 55, Defence = 75,
                        Speed = 30, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Koffing", Type = "Poison", Total = 340, HP = 40, Attack = 65, Defence = 95, Speed = 40,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Weezing", Type = "Poison", Total = 490, HP = 65, Attack = 90, Defence = 120, Speed = 75,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rhyhorn", Type = "Ground", Total = 345, HP = 80, Attack = 85, Defence = 95, Speed = 25,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rhydon", Type = "Ground", Total = 485, HP = 105, Attack = 130, Defence = 120,
                        Speed = 40, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Chansey", Type = "Normal", Total = 450, HP = 250, Attack = 5, Defence = 5, Speed = 50,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tangela", Type = "Grass", Total = 435, HP = 65, Attack = 55, Defence = 115, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kangaskhan", Type = "Normal", Total = 490, HP = 105, Attack = 95, Defence = 80,
                        Speed = 70, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "KangaskhanMega Kangaskhan", Type = "Normal", Total = 590, HP = 105, Attack = 125,
                        Defence = 100, Speed = 100, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Horsea", Type = "Water", Total = 295, HP = 30, Attack = 40, Defence = 70, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Seadra", Type = "Water", Total = 440, HP = 55, Attack = 65, Defence = 95, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Goldeen", Type = "Water", Total = 320, HP = 45, Attack = 67, Defence = 60, Speed = 58,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Seaking", Type = "Water", Total = 450, HP = 80, Attack = 92, Defence = 65, Speed = 73,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Staryu", Type = "Water", Total = 340, HP = 30, Attack = 45, Defence = 55, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Starmie", Type = "Water", Total = 520, HP = 60, Attack = 75, Defence = 85, Speed = 100,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mr. Mime", Type = "Psychic", Total = 460, HP = 40, Attack = 45, Defence = 65,
                        Speed = 90, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Scyther", Type = "Bug", Total = 500, HP = 70, Attack = 110, Defence = 80, Speed = 105,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Jynx", Type = "Psychic", Total = 455, HP = 65, Attack = 50, Defence = 35, Speed = 95,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Electabuzz", Type = "Electric", Total = 490, HP = 65, Attack = 83, Defence = 57,
                        Speed = 105, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magmar", Type = "Fire", Total = 495, HP = 65, Attack = 95, Defence = 57, Speed = 93,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pinsir", Type = "Bug", Total = 500, HP = 65, Attack = 125, Defence = 100, Speed = 85,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "PinsirMega Pinsir", Type = "Bug", Total = 600, HP = 65, Attack = 155, Defence = 120,
                        Speed = 105, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tauros", Type = "Normal", Total = 490, HP = 75, Attack = 100, Defence = 95, Speed = 110,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magikarp", Type = "Water", Total = 200, HP = 20, Attack = 10, Defence = 55, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gyarados", Type = "Water", Total = 540, HP = 95, Attack = 125, Defence = 79, Speed = 81,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "GyaradosMega Gyarados", Type = "Water", Total = 640, HP = 95, Attack = 155,
                        Defence = 109, Speed = 81, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lapras", Type = "Water", Total = 535, HP = 130, Attack = 85, Defence = 80, Speed = 60,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ditto", Type = "Normal", Total = 288, HP = 48, Attack = 48, Defence = 48, Speed = 48,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Eevee", Type = "Normal", Total = 325, HP = 55, Attack = 55, Defence = 50, Speed = 55,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vaporeon", Type = "Water", Total = 525, HP = 130, Attack = 65, Defence = 60, Speed = 65,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Jolteon", Type = "Electric", Total = 525, HP = 65, Attack = 65, Defence = 60,
                        Speed = 130, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Flareon", Type = "Fire", Total = 525, HP = 65, Attack = 130, Defence = 60, Speed = 65,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Porygon", Type = "Normal", Total = 395, HP = 65, Attack = 60, Defence = 70, Speed = 40,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Omanyte", Type = "Rock", Total = 355, HP = 35, Attack = 40, Defence = 100, Speed = 35,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Omastar", Type = "Rock", Total = 495, HP = 70, Attack = 60, Defence = 125, Speed = 55,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kabuto", Type = "Rock", Total = 355, HP = 30, Attack = 80, Defence = 90, Speed = 55,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kabutops", Type = "Rock", Total = 495, HP = 60, Attack = 115, Defence = 105, Speed = 80,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Aerodactyl", Type = "Rock", Total = 515, HP = 80, Attack = 105, Defence = 65,
                        Speed = 130, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AerodactylMega Aerodactyl", Type = "Rock", Total = 615, HP = 80, Attack = 135,
                        Defence = 85, Speed = 150, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Snorlax", Type = "Normal", Total = 540, HP = 160, Attack = 110, Defence = 65,
                        Speed = 30, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Articuno", Type = "Ice", Total = 580, HP = 90, Attack = 85, Defence = 100, Speed = 85,
                        Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Zapdos", Type = "Electric", Total = 580, HP = 90, Attack = 90, Defence = 85,
                        Speed = 100, Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Moltres", Type = "Fire", Total = 580, HP = 90, Attack = 100, Defence = 90, Speed = 90,
                        Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Dratini", Type = "Dragon", Total = 300, HP = 41, Attack = 64, Defence = 45, Speed = 50,
                        Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dragonair", Type = "Dragon", Total = 420, HP = 61, Attack = 84, Defence = 65,
                        Speed = 70, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dragonite", Type = "Dragon", Total = 600, HP = 91, Attack = 134, Defence = 95,
                        Speed = 80, Generation = 1, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mewtwo", Type = "Psychic", Total = 680, HP = 106, Attack = 110, Defence = 90,
                        Speed = 130, Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "MewtwoMega Mewtwo X", Type = "Psychic", Total = 780, HP = 106, Attack = 190,
                        Defence = 100, Speed = 130, Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "MewtwoMega Mewtwo Y", Type = "Psychic", Total = 780, HP = 106, Attack = 150,
                        Defence = 70, Speed = 140, Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Mew", Type = "Psychic", Total = 600, HP = 100, Attack = 100, Defence = 100, Speed = 100,
                        Generation = 1, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Chikorita", Type = "Grass", Total = 318, HP = 45, Attack = 49, Defence = 65, Speed = 45,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bayleef", Type = "Grass", Total = 405, HP = 60, Attack = 62, Defence = 80, Speed = 60,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Meganium", Type = "Grass", Total = 525, HP = 80, Attack = 82, Defence = 100, Speed = 80,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cyndaquil", Type = "Fire", Total = 309, HP = 39, Attack = 52, Defence = 43, Speed = 65,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Quilava", Type = "Fire", Total = 405, HP = 58, Attack = 64, Defence = 58, Speed = 80,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Typhlosion", Type = "Fire", Total = 534, HP = 78, Attack = 84, Defence = 78,
                        Speed = 100, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Totodile", Type = "Water", Total = 314, HP = 50, Attack = 65, Defence = 64, Speed = 45,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Croconaw", Type = "Water", Total = 405, HP = 65, Attack = 80, Defence = 80, Speed = 80,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Feraligatr", Type = "Water", Total = 530, HP = 85, Attack = 105, Defence = 100,
                        Speed = 78, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sentret", Type = "Normal", Total = 215, HP = 35, Attack = 46, Defence = 34, Speed = 40,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Furret", Type = "Normal", Total = 415, HP = 85, Attack = 76, Defence = 64, Speed = 90,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hoothoot", Type = "Normal", Total = 262, HP = 60, Attack = 30, Defence = 30, Speed = 42,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Noctowl", Type = "Normal", Total = 442, HP = 90, Attack = 50, Defence = 50, Speed = 62,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ledyba", Type = "Bug", Total = 265, HP = 40, Attack = 20, Defence = 30, Speed = 75,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ledian", Type = "Bug", Total = 390, HP = 55, Attack = 35, Defence = 50, Speed = 100,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spinarak", Type = "Bug", Total = 250, HP = 40, Attack = 60, Defence = 40, Speed = 45,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ariados", Type = "Bug", Total = 390, HP = 70, Attack = 90, Defence = 70, Speed = 45,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Crobat", Type = "Poison", Total = 535, HP = 85, Attack = 90, Defence = 80, Speed = 130,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Chinchou", Type = "Water", Total = 330, HP = 75, Attack = 38, Defence = 38, Speed = 59,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lanturn", Type = "Water", Total = 460, HP = 125, Attack = 58, Defence = 58, Speed = 67,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pichu", Type = "Electric", Total = 205, HP = 20, Attack = 40, Defence = 15, Speed = 30,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cleffa", Type = "Fairy", Total = 250, HP = 50, Attack = 25, Defence = 28, Speed = 22,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Igglybuff", Type = "Normal", Total = 210, HP = 90, Attack = 30, Defence = 15,
                        Speed = 75, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Togepi", Type = "Fairy", Total = 245, HP = 35, Attack = 20, Defence = 65, Speed = 20,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Togetic", Type = "Fairy", Total = 405, HP = 55, Attack = 40, Defence = 85, Speed = 20,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Natu", Type = "Psychic", Total = 320, HP = 40, Attack = 50, Defence = 45, Speed = 70,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Xatu", Type = "Psychic", Total = 470, HP = 65, Attack = 75, Defence = 70, Speed = 95,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mareep", Type = "Electric", Total = 280, HP = 55, Attack = 40, Defence = 40, Speed = 35,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Flaaffy", Type = "Electric", Total = 365, HP = 70, Attack = 55, Defence = 55,
                        Speed = 85, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ampharos", Type = "Electric", Total = 510, HP = 90, Attack = 75, Defence = 85,
                        Speed = 55, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AmpharosMega Ampharos", Type = "Electric", Total = 610, HP = 90, Attack = 95,
                        Defence = 105, Speed = 45, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bellossom", Type = "Grass", Total = 490, HP = 75, Attack = 80, Defence = 95, Speed = 50,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Marill", Type = "Water", Total = 210, HP = 70, Attack = 20, Defence = 50, Speed = 20,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Azumarill", Type = "Water", Total = 420, HP = 100, Attack = 50, Defence = 80,
                        Speed = 50, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sudowoodo", Type = "Rock", Total = 410, HP = 70, Attack = 100, Defence = 115,
                        Speed = 30, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Politoed", Type = "Water", Total = 500, HP = 90, Attack = 75, Defence = 75, Speed = 70,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hoppip", Type = "Grass", Total = 250, HP = 35, Attack = 35, Defence = 40, Speed = 100,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Skiploom", Type = "Grass", Total = 340, HP = 55, Attack = 45, Defence = 50, Speed = 80,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Jumpluff", Type = "Grass", Total = 430, HP = 75, Attack = 55, Defence = 70, Speed = 110,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Aipom", Type = "Normal", Total = 360, HP = 55, Attack = 70, Defence = 55, Speed = 80,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sunkern", Type = "Grass", Total = 180, HP = 30, Attack = 30, Defence = 30, Speed = 90,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sunflora", Type = "Grass", Total = 425, HP = 75, Attack = 75, Defence = 55, Speed = 120,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Yanma", Type = "Bug", Total = 390, HP = 65, Attack = 65, Defence = 45, Speed = 95,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wooper", Type = "Water", Total = 210, HP = 55, Attack = 45, Defence = 45, Speed = 15,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Quagsire", Type = "Water", Total = 430, HP = 95, Attack = 85, Defence = 85, Speed = 65,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Espeon", Type = "Psychic", Total = 525, HP = 65, Attack = 65, Defence = 60, Speed = 110,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Umbreon", Type = "Dark", Total = 525, HP = 95, Attack = 65, Defence = 110, Speed = 65,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Murkrow", Type = "Dark", Total = 405, HP = 60, Attack = 85, Defence = 42, Speed = 91,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slowking", Type = "Water", Total = 490, HP = 95, Attack = 75, Defence = 80, Speed = 30,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Misdreavus", Type = "Ghost", Total = 435, HP = 60, Attack = 60, Defence = 60,
                        Speed = 85, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Unown", Type = "Psychic", Total = 336, HP = 48, Attack = 72, Defence = 48, Speed = 48,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wobbuffet", Type = "Psychic", Total = 405, HP = 190, Attack = 33, Defence = 58,
                        Speed = 33, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Girafarig", Type = "Normal", Total = 455, HP = 70, Attack = 80, Defence = 65,
                        Speed = 85, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pineco", Type = "Bug", Total = 290, HP = 50, Attack = 65, Defence = 90, Speed = 15,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Forretress", Type = "Bug", Total = 465, HP = 75, Attack = 90, Defence = 140, Speed = 20,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dunsparce", Type = "Normal", Total = 415, HP = 100, Attack = 70, Defence = 80,
                        Speed = 45, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gligar", Type = "Ground", Total = 430, HP = 65, Attack = 75, Defence = 105, Speed = 85,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Steelix", Type = "Steel", Total = 510, HP = 75, Attack = 85, Defence = 200, Speed = 30,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "SteelixMega Steelix", Type = "Steel", Total = 610, HP = 75, Attack = 125, Defence = 230,
                        Speed = 30, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Snubbull", Type = "Fairy", Total = 300, HP = 60, Attack = 80, Defence = 50, Speed = 30,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Granbull", Type = "Fairy", Total = 452, HP = 90, Attack = 120, Defence = 75, Speed = 67,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Qwilfish", Type = "Water", Total = 430, HP = 65, Attack = 95, Defence = 75, Speed = 85,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shuckle", Type = "Bug", Total = 530, HP = 20, Attack = 10, Defence = 230, Speed = 5,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Heracross", Type = "Bug", Total = 500, HP = 80, Attack = 125, Defence = 75, Speed = 85,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "HeracrossMega Heracross", Type = "Bug", Total = 600, HP = 80, Attack = 185,
                        Defence = 115, Speed = 75, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sneasel", Type = "Dark", Total = 430, HP = 55, Attack = 95, Defence = 55, Speed = 115,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Teddiursa", Type = "Normal", Total = 330, HP = 60, Attack = 80, Defence = 50,
                        Speed = 40, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ursaring", Type = "Normal", Total = 500, HP = 90, Attack = 130, Defence = 75,
                        Speed = 55, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slugma", Type = "Fire", Total = 410, HP = 40, Attack = 40, Defence = 40, Speed = 25,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magcargo", Type = "Fire", Total = 510, HP = 60, Attack = 50, Defence = 120, Speed = 30,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swinub", Type = "Ice", Total = 250, HP = 50, Attack = 50, Defence = 40, Speed = 50,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Piloswine", Type = "Ice", Total = 450, HP = 100, Attack = 100, Defence = 80, Speed = 50,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Corsola", Type = "Water", Total = 410, HP = 55, Attack = 55, Defence = 85, Speed = 35,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Remoraid", Type = "Water", Total = 300, HP = 35, Attack = 65, Defence = 35, Speed = 65,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Octillery", Type = "Water", Total = 480, HP = 75, Attack = 105, Defence = 75,
                        Speed = 45, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Delibird", Type = "Ice", Total = 330, HP = 45, Attack = 55, Defence = 45, Speed = 70,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mantine", Type = "Water", Total = 465, HP = 65, Attack = 40, Defence = 70, Speed = 70,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Skarmory", Type = "Steel", Total = 465, HP = 65, Attack = 80, Defence = 140, Speed = 70,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Houndour", Type = "Dark", Total = 330, HP = 45, Attack = 60, Defence = 30, Speed = 65,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Houndoom", Type = "Dark", Total = 500, HP = 75, Attack = 90, Defence = 50, Speed = 90,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "HoundoomMega Houndoom", Type = "Dark", Total = 600, HP = 75, Attack = 110, Defence = 90,
                        Speed = 115, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kingdra", Type = "Water", Total = 540, HP = 75, Attack = 95, Defence = 95, Speed = 85,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Phanpy", Type = "Ground", Total = 330, HP = 90, Attack = 60, Defence = 60, Speed = 40,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Donphan", Type = "Ground", Total = 500, HP = 90, Attack = 120, Defence = 120,
                        Speed = 50, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Porygon2", Type = "Normal", Total = 515, HP = 85, Attack = 80, Defence = 90, Speed = 60,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Stantler", Type = "Normal", Total = 488, HP = 73, Attack = 95, Defence = 62, Speed = 88,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Smeargle", Type = "Normal", Total = 340, HP = 55, Attack = 20, Defence = 35, Speed = 75,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tyrogue", Type = "Fighting", Total = 210, HP = 35, Attack = 35, Defence = 35,
                        Speed = 35, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hitmontop", Type = "Fighting", Total = 455, HP = 50, Attack = 95, Defence = 95,
                        Speed = 70, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Smoochum", Type = "Ice", Total = 305, HP = 45, Attack = 30, Defence = 15, Speed = 65,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Elekid", Type = "Electric", Total = 360, HP = 45, Attack = 63, Defence = 37, Speed = 95,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magby", Type = "Fire", Total = 365, HP = 45, Attack = 75, Defence = 37, Speed = 83,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Miltank", Type = "Normal", Total = 490, HP = 95, Attack = 80, Defence = 105, Speed = 10,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Blissey", Type = "Normal", Total = 540, HP = 255, Attack = 10, Defence = 10, Speed = 55,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Raikou", Type = "Electric", Total = 580, HP = 90, Attack = 85, Defence = 75,
                        Speed = 115, Generation = 2, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Entei", Type = "Fire", Total = 580, HP = 115, Attack = 115, Defence = 85, Speed = 100,
                        Generation = 2, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Suicune", Type = "Water", Total = 580, HP = 100, Attack = 75, Defence = 115, Speed = 85,
                        Generation = 2, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Larvitar", Type = "Rock", Total = 300, HP = 50, Attack = 64, Defence = 50, Speed = 41,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pupitar", Type = "Rock", Total = 410, HP = 70, Attack = 84, Defence = 70, Speed = 51,
                        Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tyranitar", Type = "Rock", Total = 600, HP = 100, Attack = 134, Defence = 110,
                        Speed = 61, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "TyranitarMega Tyranitar", Type = "Dark", Total = 700, HP = 100, Attack = 164,
                        Defence = 150, Speed = 71, Generation = 2, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lugia", Type = "Psychic", Total = 680, HP = 106, Attack = 90, Defence = 130,
                        Speed = 110, Generation = 2, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Ho-oh", Type = "Fire", Total = 680, HP = 106, Attack = 130, Defence = 90, Speed = 90,
                        Generation = 2, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Celebi", Type = "Psychic", Total = 600, HP = 100, Attack = 100, Defence = 100,
                        Speed = 100, Generation = 2, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Treecko", Type = "Grass", Total = 310, HP = 40, Attack = 45, Defence = 35, Speed = 70,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Grovyle", Type = "Grass", Total = 405, HP = 50, Attack = 65, Defence = 45, Speed = 95,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sceptile", Type = "Grass", Total = 530, HP = 70, Attack = 85, Defence = 65, Speed = 120,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "SceptileMega Sceptile", Type = "Grass", Total = 630, HP = 70, Attack = 110,
                        Defence = 75, Speed = 145, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Torchic", Type = "Fire", Total = 310, HP = 45, Attack = 60, Defence = 40, Speed = 45,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Combusken", Type = "Fire", Total = 405, HP = 60, Attack = 85, Defence = 60, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Blaziken", Type = "Fire", Total = 530, HP = 80, Attack = 120, Defence = 70, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "BlazikenMega Blaziken", Type = "Fire", Total = 630, HP = 80, Attack = 160, Defence = 80,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mudkip", Type = "Water", Total = 310, HP = 50, Attack = 70, Defence = 50, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Marshtomp", Type = "Water", Total = 405, HP = 70, Attack = 85, Defence = 70, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swampert", Type = "Water", Total = 535, HP = 100, Attack = 110, Defence = 90,
                        Speed = 60, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "SwampertMega Swampert", Type = "Water", Total = 635, HP = 100, Attack = 150,
                        Defence = 110, Speed = 70, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Poochyena", Type = "Dark", Total = 220, HP = 35, Attack = 55, Defence = 35, Speed = 95,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mightyena", Type = "Dark", Total = 420, HP = 70, Attack = 90, Defence = 70, Speed = 190,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zigzagoon", Type = "Normal", Total = 240, HP = 38, Attack = 30, Defence = 41,
                        Speed = 30, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Linoone", Type = "Normal", Total = 418, HP = 78, Attack = 70, Defence = 61, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wurmple", Type = "Bug", Total = 195, HP = 45, Attack = 45, Defence = 35, Speed = 20,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Silcoon", Type = "Bug", Total = 205, HP = 50, Attack = 35, Defence = 55, Speed = 15,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Beautifly", Type = "Bug", Total = 395, HP = 60, Attack = 70, Defence = 50, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cascoon", Type = "Bug", Total = 205, HP = 50, Attack = 35, Defence = 55, Speed = 15,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dustox", Type = "Bug", Total = 405, HP = 60, Attack = 50, Defence = 70, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lotad", Type = "Water", Total = 220, HP = 40, Attack = 30, Defence = 30, Speed = 30,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lombre", Type = "Water", Total = 340, HP = 60, Attack = 50, Defence = 50, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ludicolo", Type = "Water", Total = 480, HP = 80, Attack = 70, Defence = 70, Speed = 70,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Seedot", Type = "Grass", Total = 305, HP = 44, Attack = 40, Defence = 50, Speed = 30,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nuzleaf", Type = "Grass", Total = 340, HP = 70, Attack = 70, Defence = 40, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shiftry", Type = "Grass", Total = 480, HP = 90, Attack = 100, Defence = 60, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Taillow", Type = "Normal", Total = 270, HP = 40, Attack = 55, Defence = 30, Speed = 85,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swellow", Type = "Normal", Total = 430, HP = 60, Attack = 85, Defence = 60, Speed = 125,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wingull", Type = "Water", Total = 270, HP = 40, Attack = 30, Defence = 30, Speed = 85,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pelipper", Type = "Water", Total = 430, HP = 60, Attack = 50, Defence = 100, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ralts", Type = "Psychic", Total = 198, HP = 28, Attack = 25, Defence = 25, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kirlia", Type = "Psychic", Total = 278, HP = 38, Attack = 35, Defence = 35, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gardevoir", Type = "Psychic", Total = 518, HP = 68, Attack = 65, Defence = 65,
                        Speed = 80, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "GardevoirMega Gardevoir", Type = "Psychic", Total = 618, HP = 68, Attack = 85,
                        Defence = 85, Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Surskit", Type = "Bug", Total = 269, HP = 40, Attack = 30, Defence = 32, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Masquerain", Type = "Bug", Total = 454, HP = 70, Attack = 60, Defence = 62, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shroomish", Type = "Grass", Total = 250, HP = 60, Attack = 40, Defence = 60, Speed = 35,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Breloom", Type = "Grass", Total = 460, HP = 60, Attack = 130, Defence = 80, Speed = 70,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slakoth", Type = "Normal", Total = 280, HP = 60, Attack = 60, Defence = 60, Speed = 30,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vigoroth", Type = "Normal", Total = 440, HP = 80, Attack = 80, Defence = 80,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slaking", Type = "Normal", Total = 670, HP = 150, Attack = 160, Defence = 100,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nincada", Type = "Bug", Total = 266, HP = 31, Attack = 45, Defence = 90, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ninjask", Type = "Bug", Total = 456, HP = 61, Attack = 90, Defence = 45, Speed = 160,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shedinja", Type = "Bug", Total = 236, HP = 1, Attack = 90, Defence = 45, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Whismur", Type = "Normal", Total = 310, HP = 64, Attack = 51, Defence = 23, Speed = 28,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Loudred", Type = "Normal", Total = 410, HP = 84, Attack = 71, Defence = 43, Speed = 68,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Exploud", Type = "Normal", Total = 530, HP = 104, Attack = 91, Defence = 63, Speed = 68,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Makuhita", Type = "Fighting", Total = 237, HP = 72, Attack = 60, Defence = 30,
                        Speed = 25, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hariyama", Type = "Fighting", Total = 474, HP = 144, Attack = 120, Defence = 60,
                        Speed = 50, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Azurill", Type = "Normal", Total = 190, HP = 50, Attack = 20, Defence = 40, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Nosepass", Type = "Rock", Total = 375, HP = 30, Attack = 45, Defence = 135, Speed = 30,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Skitty", Type = "Normal", Total = 280, HP = 50, Attack = 45, Defence = 45, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Delcatty", Type = "Normal", Total = 400, HP = 70, Attack = 65, Defence = 65,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sableye", Type = "Dark", Total = 380, HP = 50, Attack = 75, Defence = 75, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mawile", Type = "Steel", Total = 380, HP = 50, Attack = 85, Defence = 85, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MawileMega Mawile", Type = "Steel", Total = 480, HP = 50, Attack = 105, Defence = 125,
                        Speed = 50, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Aron", Type = "Rock", Total = 310, HP = 50, Attack = 70, Defence = 100, Speed = 30,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lairon", Type = "Rock", Total = 430, HP = 60, Attack = 90, Defence = 140, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Aggron", Type = "Steel", Total = 530, HP = 70, Attack = 110, Defence = 180, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AggronMega Aggron", Type = "Steel", Total = 630, HP = 70, Attack = 140, Defence = 230,
                        Speed = 50, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Meditite", Type = "Psychic", Total = 280, HP = 30, Attack = 40, Defence = 55,
                        Speed = 60, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Medicham", Type = "Psychic", Total = 410, HP = 60, Attack = 60, Defence = 75,
                        Speed = 80, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MedichamMega Medicham", Type = "Psychic", Total = 510, HP = 60, Attack = 100,
                        Defence = 85, Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Electrike", Type = "Electric", Total = 295, HP = 40, Attack = 45, Defence = 40,
                        Speed = 60, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Manectric", Type = "Electric", Total = 475, HP = 70, Attack = 75, Defence = 60,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "ManectricMega Manectric", Type = "Electric", Total = 575, HP = 70, Attack = 105,
                        Defence = 80, Speed = 120, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Plusle", Type = "Electric", Total = 405, HP = 60, Attack = 50, Defence = 40, Speed = 95,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Minun", Type = "Electric", Total = 405, HP = 60, Attack = 40, Defence = 50, Speed = 95,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Volbeat", Type = "Bug", Total = 400, HP = 65, Attack = 73, Defence = 55, Speed = 85,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Illumise", Type = "Bug", Total = 400, HP = 65, Attack = 47, Defence = 75, Speed = 85,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Roselia", Type = "Grass", Total = 400, HP = 50, Attack = 60, Defence = 45, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gulpin", Type = "Poison", Total = 302, HP = 70, Attack = 43, Defence = 53, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swalot", Type = "Poison", Total = 467, HP = 100, Attack = 73, Defence = 83, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Carvanha", Type = "Water", Total = 320, HP = 45, Attack = 90, Defence = 20, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sharpedo", Type = "Water", Total = 460, HP = 70, Attack = 120, Defence = 40,
                        Speed = 130, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "SharpedoMega Sharpedo", Type = "Water", Total = 560, HP = 70, Attack = 140,
                        Defence = 70, Speed = 180, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wailmer", Type = "Water", Total = 400, HP = 130, Attack = 70, Defence = 35, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wailord", Type = "Water", Total = 500, HP = 170, Attack = 90, Defence = 45, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Numel", Type = "Fire", Total = 305, HP = 60, Attack = 60, Defence = 40, Speed = 35,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Camerupt", Type = "Fire", Total = 460, HP = 70, Attack = 100, Defence = 70, Speed = 20,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "CameruptMega Camerupt", Type = "Fire", Total = 560, HP = 70, Attack = 120,
                        Defence = 100, Speed = 20, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Torkoal", Type = "Fire", Total = 470, HP = 70, Attack = 85, Defence = 140, Speed = 20,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spoink", Type = "Psychic", Total = 330, HP = 60, Attack = 25, Defence = 35, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Grumpig", Type = "Psychic", Total = 470, HP = 80, Attack = 45, Defence = 65, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spinda", Type = "Normal", Total = 360, HP = 60, Attack = 60, Defence = 60, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Trapinch", Type = "Ground", Total = 290, HP = 45, Attack = 100, Defence = 45,
                        Speed = 10, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vibrava", Type = "Ground", Total = 340, HP = 50, Attack = 70, Defence = 50, Speed = 70,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Flygon", Type = "Ground", Total = 520, HP = 80, Attack = 100, Defence = 80, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cacnea", Type = "Grass", Total = 335, HP = 50, Attack = 85, Defence = 40, Speed = 35,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cacturne", Type = "Grass", Total = 475, HP = 70, Attack = 115, Defence = 60, Speed = 45,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swablu", Type = "Normal", Total = 310, HP = 45, Attack = 40, Defence = 60, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Altaria", Type = "Dragon", Total = 490, HP = 75, Attack = 70, Defence = 90, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AltariaMega Altaria", Type = "Dragon", Total = 590, HP = 75, Attack = 110,
                        Defence = 110, Speed = 80, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zangoose", Type = "Normal", Total = 458, HP = 73, Attack = 115, Defence = 60,
                        Speed = 90, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Seviper", Type = "Poison", Total = 458, HP = 73, Attack = 100, Defence = 60, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lunatone", Type = "Rock", Total = 442, HP = 70, Attack = 55, Defence = 65, Speed = 70,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Solrock", Type = "Rock", Total = 430, HP = 70, Attack = 95, Defence = 85, Speed = 70,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Barboach", Type = "Water", Total = 288, HP = 50, Attack = 48, Defence = 43, Speed = 32,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Whiscash", Type = "Water", Total = 468, HP = 110, Attack = 78, Defence = 73, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Corphish", Type = "Water", Total = 308, HP = 43, Attack = 80, Defence = 65, Speed = 35,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Crawdaunt", Type = "Water", Total = 468, HP = 63, Attack = 120, Defence = 85,
                        Speed = 80, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Baltoy", Type = "Ground", Total = 300, HP = 40, Attack = 40, Defence = 55, Speed = 55,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Claydol", Type = "Ground", Total = 500, HP = 60, Attack = 70, Defence = 105, Speed = 75,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lileep", Type = "Rock", Total = 355, HP = 66, Attack = 41, Defence = 77, Speed = 23,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cradily", Type = "Rock", Total = 495, HP = 86, Attack = 81, Defence = 97, Speed = 43,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Anorith", Type = "Rock", Total = 381, HP = 45, Attack = 95, Defence = 50, Speed = 75,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Armaldo", Type = "Rock", Total = 495, HP = 75, Attack = 125, Defence = 100, Speed = 45,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Feebas", Type = "Water", Total = 200, HP = 20, Attack = 15, Defence = 20, Speed = 80,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Milotic", Type = "Water", Total = 540, HP = 95, Attack = 60, Defence = 79, Speed = 81,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Castform", Type = "Normal", Total = 420, HP = 70, Attack = 70, Defence = 70,
                        Speed = 110, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kecleon", Type = "Normal", Total = 430, HP = 60, Attack = 90, Defence = 70, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shuppet", Type = "Ghost", Total = 295, HP = 44, Attack = 75, Defence = 35, Speed = 45,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Banette", Type = "Ghost", Total = 455, HP = 64, Attack = 115, Defence = 65, Speed = 65,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "BanetteMega Banette", Type = "Ghost", Total = 555, HP = 64, Attack = 165, Defence = 75,
                        Speed = 75, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Duskull", Type = "Ghost", Total = 295, HP = 20, Attack = 40, Defence = 90, Speed = 25,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dusclops", Type = "Ghost", Total = 455, HP = 40, Attack = 70, Defence = 130, Speed = 25,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tropius", Type = "Grass", Total = 460, HP = 99, Attack = 68, Defence = 83, Speed = 51,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Chimecho", Type = "Psychic", Total = 425, HP = 65, Attack = 50, Defence = 70,
                        Speed = 65, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Absol", Type = "Dark", Total = 465, HP = 65, Attack = 130, Defence = 60, Speed = 75,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AbsolMega Absol", Type = "Dark", Total = 565, HP = 65, Attack = 150, Defence = 60,
                        Speed = 115, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wynaut", Type = "Psychic", Total = 210, HP = 95, Attack = 23, Defence = 48, Speed = 23,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Snorunt", Type = "Ice", Total = 300, HP = 50, Attack = 50, Defence = 50, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Glalie", Type = "Ice", Total = 480, HP = 80, Attack = 80, Defence = 80, Speed = 100,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "GlalieMega Glalie", Type = "Ice", Total = 580, HP = 80, Attack = 120, Defence = 80,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spheal", Type = "Ice", Total = 290, HP = 70, Attack = 40, Defence = 50, Speed = 20,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sealeo", Type = "Ice", Total = 410, HP = 90, Attack = 60, Defence = 70, Speed = 40,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Walrein", Type = "Ice", Total = 530, HP = 110, Attack = 80, Defence = 90, Speed = 60,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Clamperl", Type = "Water", Total = 345, HP = 35, Attack = 64, Defence = 85, Speed = 32,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Huntail", Type = "Water", Total = 485, HP = 55, Attack = 104, Defence = 105, Speed = 52,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gorebyss", Type = "Water", Total = 485, HP = 55, Attack = 84, Defence = 105, Speed = 52,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Relicanth", Type = "Water", Total = 485, HP = 100, Attack = 90, Defence = 130,
                        Speed = 55, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Luvdisc", Type = "Water", Total = 330, HP = 43, Attack = 30, Defence = 55, Speed = 97,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bagon", Type = "Dragon", Total = 300, HP = 45, Attack = 75, Defence = 60, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shelgon", Type = "Dragon", Total = 420, HP = 65, Attack = 95, Defence = 100, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Salamence", Type = "Dragon", Total = 600, HP = 95, Attack = 135, Defence = 80,
                        Speed = 100, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "SalamenceMega Salamence", Type = "Dragon", Total = 700, HP = 95, Attack = 145,
                        Defence = 130, Speed = 120, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Beldum", Type = "Steel", Total = 300, HP = 40, Attack = 55, Defence = 80, Speed = 30,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Metang", Type = "Steel", Total = 420, HP = 60, Attack = 75, Defence = 100, Speed = 50,
                        Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Metagross", Type = "Steel", Total = 600, HP = 80, Attack = 135, Defence = 130,
                        Speed = 70, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MetagrossMega Metagross", Type = "Steel", Total = 700, HP = 80, Attack = 145,
                        Defence = 150, Speed = 110, Generation = 3, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Regirock", Type = "Rock", Total = 580, HP = 80, Attack = 100, Defence = 200, Speed = 50,
                        Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Regice", Type = "Ice", Total = 580, HP = 80, Attack = 50, Defence = 100, Speed = 50,
                        Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Registeel", Type = "Steel", Total = 580, HP = 80, Attack = 75, Defence = 150,
                        Speed = 50, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Latias", Type = "Dragon", Total = 600, HP = 80, Attack = 80, Defence = 90, Speed = 110,
                        Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "LatiasMega Latias", Type = "Dragon", Total = 700, HP = 80, Attack = 100, Defence = 120,
                        Speed = 110, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Latios", Type = "Dragon", Total = 600, HP = 80, Attack = 90, Defence = 80, Speed = 110,
                        Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "LatiosMega Latios", Type = "Dragon", Total = 700, HP = 80, Attack = 130, Defence = 100,
                        Speed = 110, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Kyogre", Type = "Water", Total = 670, HP = 100, Attack = 100, Defence = 90, Speed = 90,
                        Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "KyogrePrimal Kyogre", Type = "Water", Total = 770, HP = 100, Attack = 150, Defence = 90,
                        Speed = 90, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Groudon", Type = "Ground", Total = 670, HP = 100, Attack = 150, Defence = 140,
                        Speed = 90, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "GroudonPrimal Groudon", Type = "Ground", Total = 770, HP = 100, Attack = 180,
                        Defence = 160, Speed = 90, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Rayquaza", Type = "Dragon", Total = 680, HP = 105, Attack = 150, Defence = 90,
                        Speed = 95, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "RayquazaMega Rayquaza", Type = "Dragon", Total = 780, HP = 105, Attack = 180,
                        Defence = 100, Speed = 115, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Jirachi", Type = "Steel", Total = 600, HP = 100, Attack = 100, Defence = 100,
                        Speed = 100, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "DeoxysNormal Forme", Type = "Psychic", Total = 600, HP = 50, Attack = 150, Defence = 50,
                        Speed = 150, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "DeoxysAttack Forme", Type = "Psychic", Total = 600, HP = 50, Attack = 180, Defence = 20,
                        Speed = 150, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "DeoxysDefense Forme", Type = "Psychic", Total = 600, HP = 50, Attack = 70,
                        Defence = 160, Speed = 90, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "DeoxysSpeed Forme", Type = "Psychic", Total = 600, HP = 50, Attack = 95, Defence = 90,
                        Speed = 180, Generation = 3, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Turtwig", Type = "Grass", Total = 318, HP = 55, Attack = 68, Defence = 64, Speed = 31,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Grotle", Type = "Grass", Total = 405, HP = 75, Attack = 89, Defence = 85, Speed = 36,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Torterra", Type = "Grass", Total = 525, HP = 95, Attack = 109, Defence = 105,
                        Speed = 56, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Chimchar", Type = "Fire", Total = 309, HP = 44, Attack = 58, Defence = 44, Speed = 61,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Monferno", Type = "Fire", Total = 405, HP = 64, Attack = 78, Defence = 52, Speed = 81,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Infernape", Type = "Fire", Total = 534, HP = 76, Attack = 104, Defence = 71,
                        Speed = 108, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Piplup", Type = "Water", Total = 314, HP = 53, Attack = 51, Defence = 53, Speed = 40,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Prinplup", Type = "Water", Total = 405, HP = 64, Attack = 66, Defence = 68, Speed = 57,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Empoleon", Type = "Water", Total = 530, HP = 84, Attack = 86, Defence = 88, Speed = 60,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Starly", Type = "Normal", Total = 243, HP = 40, Attack = 55, Defence = 30, Speed = 63,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Staravia", Type = "Normal", Total = 340, HP = 55, Attack = 75, Defence = 50, Speed = 80,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Staraptor", Type = "Normal", Total = 485, HP = 85, Attack = 120, Defence = 70,
                        Speed = 110, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bidoof", Type = "Normal", Total = 250, HP = 59, Attack = 45, Defence = 40, Speed = 46,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bibarel", Type = "Normal", Total = 430, HP = 85, Attack = 85, Defence = 60, Speed = 100,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kricketot", Type = "Bug", Total = 194, HP = 37, Attack = 25, Defence = 41, Speed = 22,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kricketune", Type = "Bug", Total = 384, HP = 77, Attack = 85, Defence = 51, Speed = 71,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shinx", Type = "Electric", Total = 280, HP = 45, Attack = 65, Defence = 34, Speed = 36,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Luxio", Type = "Electric", Total = 410, HP = 60, Attack = 85, Defence = 49, Speed = 66,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Luxray", Type = "Electric", Total = 523, HP = 80, Attack = 120, Defence = 79,
                        Speed = 84, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Budew", Type = "Grass", Total = 280, HP = 40, Attack = 30, Defence = 35, Speed = 50,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Roserade", Type = "Grass", Total = 515, HP = 60, Attack = 70, Defence = 65, Speed = 90,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cranidos", Type = "Rock", Total = 350, HP = 67, Attack = 125, Defence = 40, Speed = 58,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rampardos", Type = "Rock", Total = 495, HP = 97, Attack = 165, Defence = 60, Speed = 73,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shieldon", Type = "Rock", Total = 350, HP = 30, Attack = 42, Defence = 118, Speed = 30,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bastiodon", Type = "Rock", Total = 495, HP = 60, Attack = 52, Defence = 168, Speed = 30,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Burmy", Type = "Bug", Total = 224, HP = 40, Attack = 29, Defence = 45, Speed = 36,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "WormadamPlant Cloak", Type = "Bug", Total = 424, HP = 60, Attack = 59, Defence = 85,
                        Speed = 60, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "WormadamSandy Cloak", Type = "Bug", Total = 424, HP = 60, Attack = 79, Defence = 105,
                        Speed = 36, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "WormadamTrash Cloak", Type = "Bug", Total = 424, HP = 60, Attack = 69, Defence = 95,
                        Speed = 66, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mothim", Type = "Bug", Total = 424, HP = 70, Attack = 94, Defence = 50, Speed = 66,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Combee", Type = "Bug", Total = 244, HP = 30, Attack = 30, Defence = 42, Speed = 42,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vespiquen", Type = "Bug", Total = 474, HP = 70, Attack = 80, Defence = 102, Speed = 42,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pachirisu", Type = "Electric", Total = 405, HP = 60, Attack = 45, Defence = 70,
                        Speed = 95, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Buizel", Type = "Water", Total = 330, HP = 55, Attack = 65, Defence = 35, Speed = 85,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Floatzel", Type = "Water", Total = 495, HP = 85, Attack = 105, Defence = 55,
                        Speed = 105, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cherubi", Type = "Grass", Total = 335, HP = 45, Attack = 35, Defence = 45, Speed = 85,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gible", Type = "Dragon", Total = 300, HP = 58, Attack = 70, Defence = 45, Speed = 42,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gabite", Type = "Dragon", Total = 410, HP = 68, Attack = 90, Defence = 65, Speed = 87,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Garchomp", Type = "Dragon", Total = 600, HP = 108, Attack = 130, Defence = 95,
                        Speed = 102, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "GarchompMega Garchomp", Type = "Dragon", Total = 700, HP = 108, Attack = 170,
                        Defence = 115, Speed = 92, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Munchlax", Type = "Normal", Total = 410, HP = 135, Attack = 85, Defence = 40, Speed = 5,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Riolu", Type = "Fighting", Total = 285, HP = 40, Attack = 70, Defence = 40, Speed = 60,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lucario", Type = "Fighting", Total = 525, HP = 70, Attack = 110, Defence = 70,
                        Speed = 90, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "LucarioMega Lucario", Type = "Fighting", Total = 625, HP = 70, Attack = 145,
                        Defence = 88, Speed = 112, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hippopotas", Type = "Ground", Total = 330, HP = 68, Attack = 72, Defence = 78,
                        Speed = 32, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hippowdon", Type = "Ground", Total = 525, HP = 108, Attack = 112, Defence = 118,
                        Speed = 87, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Skorupi", Type = "Poison", Total = 330, HP = 40, Attack = 50, Defence = 90, Speed = 60,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Drapion", Type = "Poison", Total = 500, HP = 70, Attack = 90, Defence = 110, Speed = 90,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Croagunk", Type = "Poison", Total = 300, HP = 48, Attack = 61, Defence = 40, Speed = 50,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Toxicroak", Type = "Poison", Total = 490, HP = 83, Attack = 106, Defence = 65,
                        Speed = 85, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Carnivine", Type = "Grass", Total = 454, HP = 74, Attack = 100, Defence = 72,
                        Speed = 46, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Finneon", Type = "Water", Total = 330, HP = 49, Attack = 49, Defence = 56, Speed = 66,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lumineon", Type = "Water", Total = 460, HP = 69, Attack = 69, Defence = 76, Speed = 86,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mantyke", Type = "Water", Total = 345, HP = 45, Attack = 20, Defence = 50, Speed = 50,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Snover", Type = "Grass", Total = 314, HP = 60, Attack = 62, Defence = 50, Speed = 42,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Abomasnow", Type = "Grass", Total = 494, HP = 90, Attack = 92, Defence = 75, Speed = 42,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AbomasnowMega Abomasnow", Type = "Grass", Total = 594, HP = 90, Attack = 132,
                        Defence = 105, Speed = 32, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Weavile", Type = "Dark", Total = 510, HP = 70, Attack = 120, Defence = 65, Speed = 125,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magnezone", Type = "Electric", Total = 535, HP = 70, Attack = 70, Defence = 115,
                        Speed = 60, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lickilicky", Type = "Normal", Total = 515, HP = 110, Attack = 85, Defence = 95,
                        Speed = 50, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rhyperior", Type = "Ground", Total = 535, HP = 115, Attack = 140, Defence = 130,
                        Speed = 40, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tangrowth", Type = "Grass", Total = 535, HP = 100, Attack = 100, Defence = 125,
                        Speed = 50, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Electivire", Type = "Electric", Total = 540, HP = 75, Attack = 123, Defence = 67,
                        Speed = 95, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Magmortar", Type = "Fire", Total = 540, HP = 75, Attack = 115, Defence = 67, Speed = 83,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Togekiss", Type = "Fairy", Total = 545, HP = 85, Attack = 50, Defence = 95, Speed = 80,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Yanmega", Type = "Bug", Total = 515, HP = 86, Attack = 76, Defence = 86, Speed = 95,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Leafeon", Type = "Grass", Total = 525, HP = 65, Attack = 110, Defence = 130, Speed = 95,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Glaceon", Type = "Ice", Total = 525, HP = 65, Attack = 60, Defence = 110, Speed = 65,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gliscor", Type = "Ground", Total = 510, HP = 75, Attack = 95, Defence = 125, Speed = 95,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mamoswine", Type = "Ice", Total = 530, HP = 110, Attack = 130, Defence = 80, Speed = 80,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Porygon-Z", Type = "Normal", Total = 535, HP = 85, Attack = 80, Defence = 70,
                        Speed = 90, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gallade", Type = "Psychic", Total = 518, HP = 68, Attack = 125, Defence = 65,
                        Speed = 80, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "GalladeMega Gallade", Type = "Psychic", Total = 618, HP = 68, Attack = 165,
                        Defence = 95, Speed = 110, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Probopass", Type = "Rock", Total = 525, HP = 60, Attack = 55, Defence = 145, Speed = 40,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dusknoir", Type = "Ghost", Total = 525, HP = 45, Attack = 100, Defence = 135,
                        Speed = 45, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Froslass", Type = "Ice", Total = 480, HP = 70, Attack = 80, Defence = 70, Speed = 110,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rotom", Type = "Electric", Total = 440, HP = 50, Attack = 50, Defence = 107, Speed = 86,
                        Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "RotomHeat Forme", Type = "Electric", Total = 520, HP = 50, Attack = 65, Defence = 107,
                        Speed = 86, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "RotomWash Forme", Type = "Electric", Total = 520, HP = 50, Attack = 65, Defence = 107,
                        Speed = 86, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "RotomFrost Forme", Type = "Electric", Total = 520, HP = 50, Attack = 65, Defence = 107,
                        Speed = 86, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "RotomFan Forme", Type = "Electric", Total = 520, HP = 50, Attack = 65, Defence = 107,
                        Speed = 86, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "RotomMow Forme", Type = "Electric", Total = 520, HP = 50, Attack = 65, Defence = 107,
                        Speed = 86, Generation = 4, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Uxie", Type = "Psychic", Total = 580, HP = 75, Attack = 75, Defence = 130, Speed = 80,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Mesprit", Type = "Psychic", Total = 580, HP = 80, Attack = 105, Defence = 105,
                        Speed = 80, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Azelf", Type = "Psychic", Total = 580, HP = 75, Attack = 125, Defence = 70, Speed = 115,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Dialga", Type = "Steel", Total = 680, HP = 100, Attack = 120, Defence = 120, Speed = 90,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Palkia", Type = "Water", Total = 680, HP = 90, Attack = 120, Defence = 100, Speed = 100,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Heatran", Type = "Fire", Total = 600, HP = 91, Attack = 90, Defence = 106, Speed = 77,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Regigigas", Type = "Normal", Total = 670, HP = 110, Attack = 160, Defence = 110,
                        Speed = 100, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "GiratinaAltered Forme", Type = "Ghost", Total = 680, HP = 150, Attack = 100,
                        Defence = 120, Speed = 90, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "GiratinaOrigin Forme", Type = "Ghost", Total = 680, HP = 150, Attack = 120,
                        Defence = 100, Speed = 90, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Cresselia", Type = "Psychic", Total = 600, HP = 120, Attack = 70, Defence = 120,
                        Speed = 85, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Phione", Type = "Water", Total = 480, HP = 80, Attack = 80, Defence = 80, Speed = 80,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Manaphy", Type = "Water", Total = 600, HP = 100, Attack = 100, Defence = 100,
                        Speed = 100, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Darkrai", Type = "Dark", Total = 600, HP = 70, Attack = 90, Defence = 90, Speed = 125,
                        Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "ShayminLand Forme", Type = "Grass", Total = 600, HP = 100, Attack = 100, Defence = 100,
                        Speed = 100, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "ShayminSky Forme", Type = "Grass", Total = 600, HP = 100, Attack = 103, Defence = 75,
                        Speed = 127, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Arceus", Type = "Normal", Total = 720, HP = 120, Attack = 120, Defence = 120,
                        Speed = 120, Generation = 4, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Victini", Type = "Psychic", Total = 600, HP = 100, Attack = 100, Defence = 100,
                        Speed = 100, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Snivy", Type = "Grass", Total = 308, HP = 45, Attack = 45, Defence = 55, Speed = 63,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Servine", Type = "Grass", Total = 413, HP = 60, Attack = 60, Defence = 75, Speed = 78,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Serperior", Type = "Grass", Total = 528, HP = 75, Attack = 75, Defence = 95,
                        Speed = 108, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tepig", Type = "Fire", Total = 308, HP = 65, Attack = 63, Defence = 45, Speed = 35,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pignite", Type = "Fire", Total = 418, HP = 90, Attack = 93, Defence = 55, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Emboar", Type = "Fire", Total = 528, HP = 110, Attack = 123, Defence = 65, Speed = 65,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Oshawott", Type = "Water", Total = 308, HP = 55, Attack = 55, Defence = 45, Speed = 45,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dewott", Type = "Water", Total = 413, HP = 75, Attack = 75, Defence = 60, Speed = 68,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Samurott", Type = "Water", Total = 528, HP = 95, Attack = 100, Defence = 85, Speed = 73,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Patrat", Type = "Normal", Total = 255, HP = 45, Attack = 55, Defence = 39, Speed = 45,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Watchog", Type = "Normal", Total = 420, HP = 60, Attack = 85, Defence = 69, Speed = 105,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lillipup", Type = "Normal", Total = 275, HP = 45, Attack = 60, Defence = 45, Speed = 45,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Herdier", Type = "Normal", Total = 370, HP = 65, Attack = 80, Defence = 65, Speed = 60,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Stoutland", Type = "Normal", Total = 500, HP = 85, Attack = 100, Defence = 90,
                        Speed = 125, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Purrloin", Type = "Dark", Total = 281, HP = 41, Attack = 50, Defence = 37, Speed = 66,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Liepard", Type = "Dark", Total = 446, HP = 64, Attack = 88, Defence = 50, Speed = 114,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pansage", Type = "Grass", Total = 316, HP = 50, Attack = 53, Defence = 48, Speed = 64,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Simisage", Type = "Grass", Total = 498, HP = 75, Attack = 98, Defence = 63, Speed = 107,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pansear", Type = "Fire", Total = 316, HP = 50, Attack = 53, Defence = 48, Speed = 64,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Simisear", Type = "Fire", Total = 498, HP = 75, Attack = 98, Defence = 63, Speed = 107,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Panpour", Type = "Water", Total = 316, HP = 50, Attack = 53, Defence = 48, Speed = 64,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Simipour", Type = "Water", Total = 498, HP = 75, Attack = 98, Defence = 63, Speed = 107,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Munna", Type = "Psychic", Total = 292, HP = 76, Attack = 25, Defence = 45, Speed = 29,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Musharna", Type = "Psychic", Total = 487, HP = 116, Attack = 55, Defence = 85,
                        Speed = 81, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pidove", Type = "Normal", Total = 264, HP = 50, Attack = 55, Defence = 50, Speed = 44,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tranquill", Type = "Normal", Total = 358, HP = 62, Attack = 77, Defence = 62,
                        Speed = 57, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Unfezant", Type = "Normal", Total = 488, HP = 80, Attack = 115, Defence = 80,
                        Speed = 98, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Blitzle", Type = "Electric", Total = 295, HP = 45, Attack = 60, Defence = 32,
                        Speed = 78, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zebstrika", Type = "Electric", Total = 497, HP = 75, Attack = 100, Defence = 63,
                        Speed = 159, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Roggenrola", Type = "Rock", Total = 280, HP = 55, Attack = 75, Defence = 85, Speed = 15,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Boldore", Type = "Rock", Total = 390, HP = 70, Attack = 105, Defence = 105, Speed = 20,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gigalith", Type = "Rock", Total = 515, HP = 85, Attack = 135, Defence = 130, Speed = 65,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Woobat", Type = "Psychic", Total = 313, HP = 55, Attack = 45, Defence = 43, Speed = 72,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swoobat", Type = "Psychic", Total = 425, HP = 67, Attack = 57, Defence = 55, Speed = 96,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Drilbur", Type = "Ground", Total = 328, HP = 60, Attack = 85, Defence = 40, Speed = 68,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Excadrill", Type = "Ground", Total = 508, HP = 110, Attack = 135, Defence = 60,
                        Speed = 88, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Audino", Type = "Normal", Total = 445, HP = 103, Attack = 60, Defence = 86, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AudinoMega Audino", Type = "Normal", Total = 545, HP = 103, Attack = 60, Defence = 126,
                        Speed = 50, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Timburr", Type = "Fighting", Total = 305, HP = 75, Attack = 80, Defence = 55,
                        Speed = 40, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gurdurr", Type = "Fighting", Total = 405, HP = 85, Attack = 105, Defence = 85,
                        Speed = 30, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Conkeldurr", Type = "Fighting", Total = 505, HP = 105, Attack = 140, Defence = 95,
                        Speed = 45, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tympole", Type = "Water", Total = 294, HP = 50, Attack = 50, Defence = 40, Speed = 64,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Palpitoad", Type = "Water", Total = 384, HP = 75, Attack = 65, Defence = 55, Speed = 84,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Seismitoad", Type = "Water", Total = 509, HP = 105, Attack = 95, Defence = 75,
                        Speed = 79, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Throh", Type = "Fighting", Total = 465, HP = 120, Attack = 100, Defence = 85,
                        Speed = 45, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sawk", Type = "Fighting", Total = 465, HP = 75, Attack = 125, Defence = 85, Speed = 35,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sewaddle", Type = "Bug", Total = 310, HP = 45, Attack = 53, Defence = 70, Speed = 42,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swadloon", Type = "Bug", Total = 370, HP = 55, Attack = 63, Defence = 90, Speed = 52,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Leavanny", Type = "Bug", Total = 500, HP = 75, Attack = 103, Defence = 80, Speed = 92,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Venipede", Type = "Bug", Total = 260, HP = 30, Attack = 45, Defence = 59, Speed = 31,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Whirlipede", Type = "Bug", Total = 360, HP = 40, Attack = 55, Defence = 99, Speed = 66,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Scolipede", Type = "Bug", Total = 475, HP = 60, Attack = 100, Defence = 89, Speed = 126,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cottonee", Type = "Grass", Total = 280, HP = 40, Attack = 27, Defence = 60, Speed = 63,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Whimsicott", Type = "Grass", Total = 480, HP = 60, Attack = 67, Defence = 85,
                        Speed = 108, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Petilil", Type = "Grass", Total = 280, HP = 45, Attack = 35, Defence = 50, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lilligant", Type = "Grass", Total = 480, HP = 70, Attack = 60, Defence = 75, Speed = 90,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Basculin", Type = "Water", Total = 410, HP = 70, Attack = 92, Defence = 65, Speed = 83,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sandile", Type = "Ground", Total = 292, HP = 50, Attack = 72, Defence = 35, Speed = 65,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Krokorok", Type = "Ground", Total = 351, HP = 60, Attack = 82, Defence = 45, Speed = 64,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Krookodile", Type = "Ground", Total = 519, HP = 95, Attack = 117, Defence = 80,
                        Speed = 127, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Darumaka", Type = "Fire", Total = 315, HP = 70, Attack = 90, Defence = 45, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "DarmanitanStandard Mode", Type = "Fire", Total = 480, HP = 105, Attack = 140,
                        Defence = 55, Speed = 95, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "DarmanitanZen Mode", Type = "Fire", Total = 540, HP = 105, Attack = 30, Defence = 105,
                        Speed = 55, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Maractus", Type = "Grass", Total = 461, HP = 75, Attack = 86, Defence = 67, Speed = 60,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dwebble", Type = "Bug", Total = 325, HP = 50, Attack = 65, Defence = 85, Speed = 5,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Crustle", Type = "Bug", Total = 475, HP = 70, Attack = 95, Defence = 125, Speed = 45,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Scraggy", Type = "Dark", Total = 348, HP = 50, Attack = 75, Defence = 70, Speed = 48,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Scrafty", Type = "Dark", Total = 488, HP = 65, Attack = 90, Defence = 115, Speed = 68,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sigilyph", Type = "Psychic", Total = 488, HP = 72, Attack = 58, Defence = 80,
                        Speed = 97, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Yamask", Type = "Ghost", Total = 303, HP = 38, Attack = 30, Defence = 85, Speed = 30,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cofagrigus", Type = "Ghost", Total = 483, HP = 58, Attack = 50, Defence = 145,
                        Speed = 30, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tirtouga", Type = "Water", Total = 328, HP = 54, Attack = 78, Defence = 103, Speed = 22,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Carracosta", Type = "Water", Total = 484, HP = 74, Attack = 108, Defence = 133,
                        Speed = 39, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Archen", Type = "Rock", Total = 401, HP = 50, Attack = 112, Defence = 45, Speed = 74,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Archeops", Type = "Rock", Total = 567, HP = 75, Attack = 140, Defence = 65, Speed = 118,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Trubbish", Type = "Poison", Total = 326, HP = 50, Attack = 50, Defence = 62, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Garbodor", Type = "Poison", Total = 473, HP = 80, Attack = 95, Defence = 82,
                        Speed = 116, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zorua", Type = "Dark", Total = 330, HP = 40, Attack = 65, Defence = 40, Speed = 65,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zoroark", Type = "Dark", Total = 508, HP = 60, Attack = 105, Defence = 60, Speed = 105,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Minccino", Type = "Normal", Total = 300, HP = 55, Attack = 50, Defence = 40, Speed = 75,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cinccino", Type = "Normal", Total = 470, HP = 75, Attack = 95, Defence = 60,
                        Speed = 140, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gothita", Type = "Psychic", Total = 290, HP = 45, Attack = 30, Defence = 50, Speed = 45,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gothorita", Type = "Psychic", Total = 370, HP = 60, Attack = 45, Defence = 70,
                        Speed = 60, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gothitelle", Type = "Psychic", Total = 490, HP = 70, Attack = 75, Defence = 95,
                        Speed = 95, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Solosis", Type = "Psychic", Total = 303, HP = 45, Attack = 30, Defence = 40, Speed = 20,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Duosion", Type = "Psychic", Total = 373, HP = 65, Attack = 40, Defence = 50, Speed = 30,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Reuniclus", Type = "Psychic", Total = 490, HP = 110, Attack = 65, Defence = 80,
                        Speed = 30, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ducklett", Type = "Water", Total = 305, HP = 62, Attack = 44, Defence = 50, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swanna", Type = "Water", Total = 473, HP = 75, Attack = 87, Defence = 63, Speed = 98,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vanillite", Type = "Ice", Total = 305, HP = 36, Attack = 50, Defence = 50, Speed = 44,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vanillish", Type = "Ice", Total = 395, HP = 51, Attack = 65, Defence = 65, Speed = 69,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vanilluxe", Type = "Ice", Total = 535, HP = 71, Attack = 95, Defence = 85, Speed = 79,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Deerling", Type = "Normal", Total = 335, HP = 60, Attack = 60, Defence = 50, Speed = 75,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sawsbuck", Type = "Normal", Total = 475, HP = 80, Attack = 100, Defence = 70,
                        Speed = 125, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Emolga", Type = "Electric", Total = 428, HP = 55, Attack = 75, Defence = 60,
                        Speed = 138, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Karrablast", Type = "Bug", Total = 315, HP = 50, Attack = 75, Defence = 45, Speed = 60,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Escavalier", Type = "Bug", Total = 495, HP = 70, Attack = 135, Defence = 105,
                        Speed = 20, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shelmet", Type = "Bug", Total = 305, HP = 50, Attack = 40, Defence = 85, Speed = 30,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Accelgor", Type = "Bug", Total = 495, HP = 80, Attack = 70, Defence = 40, Speed = 145,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Stunfisk", Type = "Ground", Total = 471, HP = 109, Attack = 66, Defence = 84,
                        Speed = 32, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mienfoo", Type = "Fighting", Total = 350, HP = 45, Attack = 85, Defence = 50,
                        Speed = 65, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mienshao", Type = "Fighting", Total = 510, HP = 65, Attack = 125, Defence = 60,
                        Speed = 120, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Druddigon", Type = "Dragon", Total = 485, HP = 77, Attack = 120, Defence = 90,
                        Speed = 48, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Golett", Type = "Ground", Total = 303, HP = 59, Attack = 74, Defence = 50, Speed = 40,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Golurk", Type = "Ground", Total = 483, HP = 89, Attack = 124, Defence = 80, Speed = 50,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pawniard", Type = "Dark", Total = 340, HP = 45, Attack = 85, Defence = 70, Speed = 40,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bisharp", Type = "Dark", Total = 490, HP = 65, Attack = 125, Defence = 100, Speed = 70,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bouffalant", Type = "Normal", Total = 490, HP = 95, Attack = 110, Defence = 95,
                        Speed = 55, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rufflet", Type = "Normal", Total = 350, HP = 70, Attack = 83, Defence = 50, Speed = 47,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Braviary", Type = "Normal", Total = 510, HP = 100, Attack = 123, Defence = 75,
                        Speed = 82, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vullaby", Type = "Dark", Total = 320, HP = 70, Attack = 55, Defence = 75, Speed = 65,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mandibuzz", Type = "Dark", Total = 510, HP = 110, Attack = 105, Defence = 105,
                        Speed = 80, Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Heatmor", Type = "Fire", Total = 484, HP = 85, Attack = 97, Defence = 66, Speed = 65,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Durant", Type = "Bug", Total = 484, HP = 58, Attack = 109, Defence = 112, Speed = 109,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Deino", Type = "Dark", Total = 300, HP = 52, Attack = 65, Defence = 50, Speed = 38,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Zweilous", Type = "Dark", Total = 371, HP = 72, Attack = 85, Defence = 70, Speed = 58,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hydreigon", Type = "Dark", Total = 600, HP = 92, Attack = 105, Defence = 90, Speed = 98,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Larvesta", Type = "Bug", Total = 360, HP = 55, Attack = 85, Defence = 55, Speed = 60,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Volcarona", Type = "Bug", Total = 550, HP = 85, Attack = 60, Defence = 65, Speed = 100,
                        Generation = 5, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cobalion", Type = "Steel", Total = 580, HP = 91, Attack = 125, Defence = 129,
                        Speed = 108, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Terrakion", Type = "Rock", Total = 580, HP = 91, Attack = 129, Defence = 90,
                        Speed = 108, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Virizion", Type = "Grass", Total = 580, HP = 91, Attack = 90, Defence = 72, Speed = 108,
                        Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "TornadusIncarnate Forme", Type = "Flying", Total = 580, HP = 79, Attack = 115,
                        Defence = 70, Speed = 111, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "TornadusTherian Forme", Type = "Flying", Total = 580, HP = 79, Attack = 100,
                        Defence = 80, Speed = 121, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "ThundurusIncarnate Forme", Type = "Electric", Total = 580, HP = 79, Attack = 115,
                        Defence = 70, Speed = 111, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "ThundurusTherian Forme", Type = "Electric", Total = 580, HP = 79, Attack = 105,
                        Defence = 80, Speed = 121, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Reshiram", Type = "Dragon", Total = 680, HP = 100, Attack = 120, Defence = 100,
                        Speed = 90, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Zekrom", Type = "Dragon", Total = 680, HP = 100, Attack = 150, Defence = 120,
                        Speed = 90, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "LandorusIncarnate Forme", Type = "Ground", Total = 600, HP = 89, Attack = 125,
                        Defence = 90, Speed = 101, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "LandorusTherian Forme", Type = "Ground", Total = 600, HP = 89, Attack = 145,
                        Defence = 90, Speed = 91, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Kyurem", Type = "Dragon", Total = 660, HP = 125, Attack = 130, Defence = 90, Speed = 95,
                        Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "KyuremBlack Kyurem", Type = "Dragon", Total = 700, HP = 125, Attack = 170, Defence = 80,
                        Speed = 95, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "KyuremWhite Kyurem", Type = "Dragon", Total = 700, HP = 125, Attack = 120, Defence = 90,
                        Speed = 95, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "KeldeoOrdinary Forme", Type = "Water", Total = 580, HP = 91, Attack = 72, Defence = 90,
                        Speed = 108, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "KeldeoResolute Forme", Type = "Water", Total = 580, HP = 91, Attack = 72, Defence = 90,
                        Speed = 108, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "MeloettaAria Forme", Type = "Normal", Total = 600, HP = 100, Attack = 128, Defence = 90,
                        Speed = 128, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "MeloettaPirouette Forme", Type = "Normal", Total = 600, HP = 100, Attack = 77,
                        Defence = 77, Speed = 128, Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Genesect", Type = "Bug", Total = 600, HP = 71, Attack = 120, Defence = 95, Speed = 99,
                        Generation = 5, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Chespin", Type = "Grass", Total = 313, HP = 56, Attack = 61, Defence = 65, Speed = 48,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Quilladin", Type = "Grass", Total = 405, HP = 61, Attack = 78, Defence = 95, Speed = 61,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Chesnaught", Type = "Grass", Total = 530, HP = 88, Attack = 107, Defence = 122,
                        Speed = 64, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Fennekin", Type = "Fire", Total = 307, HP = 40, Attack = 45, Defence = 40, Speed = 62,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Braixen", Type = "Fire", Total = 409, HP = 59, Attack = 59, Defence = 58, Speed = 90,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Delphox", Type = "Fire", Total = 534, HP = 75, Attack = 114, Defence = 72, Speed = 104,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Froakie", Type = "Water", Total = 314, HP = 41, Attack = 56, Defence = 40, Speed = 71,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Frogadier", Type = "Water", Total = 405, HP = 54, Attack = 63, Defence = 52, Speed = 97,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Greninja", Type = "Water", Total = 530, HP = 72, Attack = 95, Defence = 67, Speed = 122,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bunnelby", Type = "Normal", Total = 237, HP = 38, Attack = 36, Defence = 38, Speed = 45,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Diggersby", Type = "Normal", Total = 423, HP = 85, Attack = 56, Defence = 77,
                        Speed = 55, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Fletchling", Type = "Normal", Total = 278, HP = 45, Attack = 50, Defence = 43,
                        Speed = 90, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Fletchinder", Type = "Fire", Total = 382, HP = 62, Attack = 73, Defence = 55,
                        Speed = 84, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Talonflame", Type = "Fire", Total = 499, HP = 78, Attack = 81, Defence = 71,
                        Speed = 129, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Scatterbug", Type = "Bug", Total = 200, HP = 38, Attack = 35, Defence = 40, Speed = 42,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spewpa", Type = "Bug", Total = 213, HP = 45, Attack = 22, Defence = 60, Speed = 29,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vivillon", Type = "Bug", Total = 411, HP = 80, Attack = 52, Defence = 50, Speed = 89,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Litleo", Type = "Fire", Total = 369, HP = 62, Attack = 50, Defence = 58, Speed = 72,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pyroar", Type = "Fire", Total = 507, HP = 86, Attack = 68, Defence = 72, Speed = 101,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Flabébé", Type = "Fairy", Total = 303, HP = 44, Attack = 38, Defence = 39, Speed = 42,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Floette", Type = "Fairy", Total = 371, HP = 54, Attack = 45, Defence = 47, Speed = 55,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Florges", Type = "Fairy", Total = 552, HP = 78, Attack = 65, Defence = 68, Speed = 75,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Skiddo", Type = "Grass", Total = 350, HP = 66, Attack = 65, Defence = 48, Speed = 51,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Gogoat", Type = "Grass", Total = 531, HP = 123, Attack = 100, Defence = 62, Speed = 65,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Espurr", Type = "Psychic", Total = 355, HP = 62, Attack = 48, Defence = 54, Speed = 48,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MeowsticMale", Type = "Psychic", Total = 480, HP = 74, Attack = 48, Defence = 76,
                        Speed = 104, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MeowsticFemale", Type = "Psychic", Total = 480, HP = 74, Attack = 48, Defence = 76,
                        Speed = 104, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Honedge", Type = "Steel", Total = 325, HP = 45, Attack = 80, Defence = 100, Speed = 28,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Doublade", Type = "Steel", Total = 448, HP = 59, Attack = 110, Defence = 150,
                        Speed = 35, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AegislashBlade Forme", Type = "Steel", Total = 520, HP = 60, Attack = 50, Defence = 150,
                        Speed = 60, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "AegislashShield Forme", Type = "Steel", Total = 520, HP = 60, Attack = 150,
                        Defence = 50, Speed = 60, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Spritzee", Type = "Fairy", Total = 341, HP = 58, Attack = 52, Defence = 60, Speed = 23,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Aromatisse", Type = "Fairy", Total = 462, HP = 101, Attack = 72, Defence = 72,
                        Speed = 29, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Swirlix", Type = "Fairy", Total = 341, HP = 62, Attack = 48, Defence = 66, Speed = 49,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Slurpuff", Type = "Fairy", Total = 480, HP = 82, Attack = 80, Defence = 86, Speed = 82,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Binacle", Type = "Rock", Total = 335, HP = 42, Attack = 52, Defence = 67, Speed = 54,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Barbaracle", Type = "Rock", Total = 500, HP = 72, Attack = 105, Defence = 115,
                        Speed = 58, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Skrelp", Type = "Poison", Total = 320, HP = 50, Attack = 60, Defence = 60, Speed = 50,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dragalge", Type = "Poison", Total = 480, HP = 65, Attack = 75, Defence = 90, Speed = 50,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Clauncher", Type = "Water", Total = 300, HP = 50, Attack = 53, Defence = 62, Speed = 44,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Clawitzer", Type = "Water", Total = 530, HP = 71, Attack = 73, Defence = 88, Speed = 59,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Helioptile", Type = "Electric", Total = 289, HP = 44, Attack = 38, Defence = 33,
                        Speed = 70, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Heliolisk", Type = "Electric", Total = 481, HP = 62, Attack = 55, Defence = 52,
                        Speed = 109, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tyrunt", Type = "Rock", Total = 362, HP = 58, Attack = 89, Defence = 77, Speed = 48,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tyrantrum", Type = "Rock", Total = 521, HP = 82, Attack = 121, Defence = 119,
                        Speed = 74, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Amaura", Type = "Rock", Total = 362, HP = 77, Attack = 59, Defence = 50, Speed = 46,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Aurorus", Type = "Rock", Total = 521, HP = 123, Attack = 77, Defence = 72, Speed = 58,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sylveon", Type = "Fairy", Total = 525, HP = 95, Attack = 65, Defence = 65, Speed = 60,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hawlucha", Type = "Fighting", Total = 500, HP = 78, Attack = 92, Defence = 75,
                        Speed = 118, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dedenne", Type = "Electric", Total = 431, HP = 67, Attack = 58, Defence = 57,
                        Speed = 101, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Carbink", Type = "Rock", Total = 500, HP = 50, Attack = 50, Defence = 150, Speed = 50,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Goomy", Type = "Dragon", Total = 300, HP = 45, Attack = 50, Defence = 35, Speed = 40,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sliggoo", Type = "Dragon", Total = 452, HP = 68, Attack = 75, Defence = 53, Speed = 66,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Goodra", Type = "Dragon", Total = 600, HP = 90, Attack = 100, Defence = 70, Speed = 80,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Klefki", Type = "Steel", Total = 470, HP = 57, Attack = 80, Defence = 91, Speed = 65,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Phantump", Type = "Ghost", Total = 309, HP = 43, Attack = 70, Defence = 48, Speed = 38,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Trevenant", Type = "Ghost", Total = 474, HP = 85, Attack = 110, Defence = 76,
                        Speed = 56, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "PumpkabooAverage Size", Type = "Ghost", Total = 335, HP = 49, Attack = 66, Defence = 70,
                        Speed = 50, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "GourgeistAverage Size", Type = "Ghost", Total = 494, HP = 65, Attack = 90,
                        Defence = 122, Speed = 82, Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bergmite", Type = "Ice", Total = 304, HP = 55, Attack = 69, Defence = 85, Speed = 28,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Avalugg", Type = "Ice", Total = 514, HP = 95, Attack = 117, Defence = 184, Speed = 28,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Noibat", Type = "Flying", Total = 245, HP = 40, Attack = 30, Defence = 35, Speed = 55,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Noivern", Type = "Flying", Total = 535, HP = 85, Attack = 70, Defence = 80, Speed = 123,
                        Generation = 6, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Xerneas", Type = "Fairy", Total = 680, HP = 126, Attack = 131, Defence = 95, Speed = 99,
                        Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Yveltal", Type = "Dark", Total = 680, HP = 126, Attack = 131, Defence = 95, Speed = 99,
                        Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Zygarde Forme", Type = "Dragon", Total = 600, HP = 108, Attack = 100, Defence = 121,
                        Speed = 95, Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Diancie", Type = "Rock", Total = 600, HP = 50, Attack = 100, Defence = 150, Speed = 50,
                        Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "DiancieMega Diancie", Type = "Rock", Total = 700, HP = 50, Attack = 160, Defence = 110,
                        Speed = 110, Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Hoopa Confined", Type = "Psychic", Total = 600, HP = 80, Attack = 110, Defence = 60,
                        Speed = 70, Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Hoopa Unbound", Type = "Psychic", Total = 680, HP = 80, Attack = 160, Defence = 60,
                        Speed = 80, Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Volcanion", Type = "Fire", Total = 600, HP = 80, Attack = 110, Defence = 120,
                        Speed = 70, Generation = 6, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Rowlet", Type = "Grass", Total = 320, HP = 68, Attack = 55, Defence = 55, Speed = 42,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dartrix", Type = "Grass", Total = 420, HP = 78, Attack = 75, Defence = 75, Speed = 52,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Decidueye", Type = "Grass", Total = 530, HP = 78, Attack = 107, Defence = 75,
                        Speed = 70, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Litten", Type = "Fire", Total = 320, HP = 45, Attack = 65, Defence = 40, Speed = 70,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Torracat", Type = "Fire", Total = 420, HP = 65, Attack = 85, Defence = 50, Speed = 90,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Incineroar", Type = "Fire", Total = 530, HP = 95, Attack = 115, Defence = 90,
                        Speed = 60, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Popplio", Type = "Water", Total = 320, HP = 50, Attack = 54, Defence = 54, Speed = 40,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Brionne", Type = "Water", Total = 420, HP = 60, Attack = 69, Defence = 69, Speed = 50,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Primarina", Type = "Water", Total = 530, HP = 80, Attack = 74, Defence = 74, Speed = 60,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Grubbin", Type = "Bug", Total = 320, HP = 47, Attack = 62, Defence = 45, Speed = 46,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Charjabug", Type = "Bug", Total = 400, HP = 57, Attack = 82, Defence = 95, Speed = 36,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Vikavolt", Type = "Bug", Total = 500, HP = 77, Attack = 70, Defence = 90, Speed = 105,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Crabrawler", Type = "Fighting", Total = 395, HP = 47, Attack = 82, Defence = 57,
                        Speed = 63, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Crabominable", Type = "Fighting", Total = 478, HP = 97, Attack = 132, Defence = 77,
                        Speed = 43, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "OricorioBaile Style", Type = "Fire", Total = 410, HP = 75, Attack = 70, Defence = 70,
                        Speed = 93, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "OricorioPom-Pom Style", Type = "Electric", Total = 410, HP = 75, Attack = 70,
                        Defence = 70, Speed = 93, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "OricorioPa'u Style", Type = "Psychic", Total = 410, HP = 75, Attack = 70, Defence = 70,
                        Speed = 93, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "OricorioSensu Style", Type = "Ghost", Total = 410, HP = 75, Attack = 70, Defence = 70,
                        Speed = 93, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Cutiefly", Type = "Bug", Total = 284, HP = 40, Attack = 45, Defence = 40, Speed = 84,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Ribombee", Type = "Bug", Total = 464, HP = 60, Attack = 55, Defence = 60, Speed = 109,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Rockruff", Type = "Rock", Total = 320, HP = 45, Attack = 65, Defence = 40, Speed = 60,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "LycanrocMidday Form", Type = "Rock", Total = 487, HP = 75, Attack = 115, Defence = 65,
                        Speed = 82, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "LycanrocMidnight Form", Type = "Rock", Total = 487, HP = 85, Attack = 115, Defence = 75,
                        Speed = 82, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "WishiwashiSolo Form", Type = "Water", Total = 175, HP = 45, Attack = 20, Defence = 20,
                        Speed = 90, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "WishiwashiSchool Form", Type = "Water", Total = 620, HP = 45, Attack = 100,
                        Defence = 80, Speed = 30, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mareanie", Type = "Poison", Total = 325, HP = 50, Attack = 60, Defence = 62, Speed = 50,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Toxapex", Type = "Poison", Total = 495, HP = 50, Attack = 63, Defence = 152, Speed = 35,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mudbray", Type = "Ground", Total = 385, HP = 70, Attack = 100, Defence = 70, Speed = 45,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Mudsdale", Type = "Ground", Total = 500, HP = 100, Attack = 125, Defence = 100,
                        Speed = 30, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dewpider", Type = "Water", Total = 269, HP = 38, Attack = 40, Defence = 52, Speed = 27,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Araquanid", Type = "Water", Total = 454, HP = 68, Attack = 70, Defence = 92, Speed = 74,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Fomantis", Type = "Grass", Total = 250, HP = 40, Attack = 55, Defence = 35, Speed = 35,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Lurantis", Type = "Grass", Total = 480, HP = 70, Attack = 105, Defence = 90, Speed = 45,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Morelull", Type = "Grass", Total = 285, HP = 40, Attack = 35, Defence = 55, Speed = 15,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Shiinotic", Type = "Grass", Total = 480, HP = 60, Attack = 45, Defence = 80, Speed = 35,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Salandit", Type = "Poison", Total = 320, HP = 48, Attack = 44, Defence = 40, Speed = 77,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Salazzle", Type = "Poison", Total = 480, HP = 68, Attack = 64, Defence = 60,
                        Speed = 118, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Stufful", Type = "Normal", Total = 340, HP = 70, Attack = 75, Defence = 50, Speed = 23,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bewear", Type = "Normal", Total = 500, HP = 120, Attack = 125, Defence = 80, Speed = 65,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bounsweet", Type = "Grass", Total = 210, HP = 42, Attack = 30, Defence = 38, Speed = 30,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Steenee", Type = "Grass", Total = 290, HP = 52, Attack = 40, Defence = 48, Speed = 50,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tsareena", Type = "Grass", Total = 510, HP = 72, Attack = 120, Defence = 98, Speed = 70,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Comfey", Type = "Fairy", Total = 485, HP = 51, Attack = 52, Defence = 90, Speed = 100,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Oranguru", Type = "Normal", Total = 460, HP = 90, Attack = 90, Defence = 80, Speed = 60,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Passimian", Type = "Fighting", Total = 490, HP = 100, Attack = 120, Defence = 90,
                        Speed = 80, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Wimpod", Type = "Bug", Total = 230, HP = 25, Attack = 35, Defence = 40, Speed = 50,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Golisopod", Type = "Bug", Total = 530, HP = 75, Attack = 125, Defence = 140, Speed = 40,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Sandygast", Type = "Ghost", Total = 320, HP = 55, Attack = 55, Defence = 80, Speed = 15,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Palossand", Type = "Ghost", Total = 480, HP = 85, Attack = 75, Defence = 110,
                        Speed = 35, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Pyukumuku", Type = "Water", Total = 410, HP = 55, Attack = 60, Defence = 130, Speed = 5,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Silvally", Type = "Normal", Total = 570, HP = 95, Attack = 95, Defence = 95, Speed = 95,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MiniorMeteor Form", Type = "Rock", Total = 480, HP = 60, Attack = 60, Defence = 100,
                        Speed = 60, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MiniorCore Form", Type = "Rock", Total = 480, HP = 60, Attack = 100, Defence = 60,
                        Speed = 120, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Komala", Type = "Normal", Total = 480, HP = 65, Attack = 115, Defence = 65, Speed = 65,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Turtonator", Type = "Fire", Total = 485, HP = 60, Attack = 78, Defence = 135,
                        Speed = 365, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Togedemaru", Type = "Electric", Total = 435, HP = 65, Attack = 98, Defence = 63,
                        Speed = 99, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "MimikyuDisguised Form", Type = "Ghost", Total = 476, HP = 55, Attack = 90, Defence = 80,
                        Speed = 96, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Bruxish", Type = "Water", Total = 475, HP = 68, Attack = 105, Defence = 70, Speed = 92,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Drampa", Type = "Normal", Total = 485, HP = 78, Attack = 60, Defence = 85, Speed = 36,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Dhelmise", Type = "Ghost", Total = 500, HP = 70, Attack = 131, Defence = 100,
                        Speed = 44, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Jangmo-o", Type = "Dragon", Total = 300, HP = 45, Attack = 55, Defence = 65, Speed = 45,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Hakamo-o", Type = "Dragon", Total = 420, HP = 55, Attack = 75, Defence = 90, Speed = 60,
                        Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Kommo-o", Type = "Dragon", Total = 600, HP = 75, Attack = 110, Defence = 125,
                        Speed = 85, Generation = 7, Legendary = false
                    },
                    new Pokemon
                    {
                        Name = "Tapu Koko", Type = "Electric", Total = 570, HP = 70, Attack = 115, Defence = 85,
                        Speed = 130, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Tapu Lele", Type = "Psychic", Total = 570, HP = 70, Attack = 85, Defence = 75,
                        Speed = 95, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Tapu Bulu", Type = "Grass", Total = 570, HP = 70, Attack = 130, Defence = 115,
                        Speed = 75, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Tapu Fini", Type = "Water", Total = 570, HP = 70, Attack = 75, Defence = 115,
                        Speed = 85, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Cosmog", Type = "Psychic", Total = 200, HP = 43, Attack = 29, Defence = 31, Speed = 37,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Cosmoem", Type = "Psychic", Total = 400, HP = 43, Attack = 29, Defence = 131,
                        Speed = 37, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Solgaleo", Type = "Psychic", Total = 680, HP = 137, Attack = 137, Defence = 107,
                        Speed = 97, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Lunala", Type = "Psychic", Total = 680, HP = 137, Attack = 113, Defence = 89,
                        Speed = 97, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Nihilego", Type = "Rock", Total = 570, HP = 109, Attack = 53, Defence = 47, Speed = 103,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Buzzwole", Type = "Bug", Total = 570, HP = 107, Attack = 139, Defence = 139, Speed = 79,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Pheromosa", Type = "Bug", Total = 570, HP = 71, Attack = 137, Defence = 37, Speed = 151,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Xurkitree", Type = "Electric", Total = 570, HP = 83, Attack = 89, Defence = 71,
                        Speed = 83, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Celesteela", Type = "Steel", Total = 570, HP = 97, Attack = 101, Defence = 103,
                        Speed = 61, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Kartana", Type = "Grass", Total = 570, HP = 59, Attack = 181, Defence = 131,
                        Speed = 109, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Guzzlord", Type = "Dark", Total = 570, HP = 223, Attack = 101, Defence = 53, Speed = 43,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Necrozma", Type = "Psychic", Total = 600, HP = 97, Attack = 107, Defence = 101,
                        Speed = 79, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Magearna", Type = "Steel", Total = 500, HP = 80, Attack = 95, Defence = 115, Speed = 65,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Marshadow", Type = "Fighting", Total = 600, HP = 90, Attack = 125, Defence = 80,
                        Speed = 125, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Poipole", Type = "Poison", Total = 420, HP = 67, Attack = 73, Defence = 67, Speed = 73,
                        Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Naganadel", Type = "Poison", Total = 540, HP = 73, Attack = 73, Defence = 73,
                        Speed = 121, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Stakataka", Type = "Rock", Total = 570, HP = 61, Attack = 131, Defence = 211,
                        Speed = 13, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Blacephalon", Type = "Fire", Total = 570, HP = 53, Attack = 127, Defence = 53,
                        Speed = 107, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Zeraora", Type = "Electric", Total = 600, HP = 88, Attack = 112, Defence = 75,
                        Speed = 143, Generation = 7, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Meltan", Type = "Steel", Total = 300, HP = 46, Attack = 65, Defence = 65, Speed = 34,
                        Generation = 8, Legendary = true
                    },
                    new Pokemon
                    {
                        Name = "Melmetal", Type = "Steel", Total = 600, HP = 135, Attack = 143, Defence = 143,
                        Speed = 34, Generation = 8, Legendary = true
                    }
                };

                _context.Pokemons.AddRange(pokemonList);
                _context.SaveChanges();
            }

            // add the trainer if there isn't one
            if (!_context.Trainers.Any())
            {
                var pikachu = _context.Pokemons.Single(pokemon => pokemon.Name == "Pikachu");
                var trainer = new Trainer { Name = "Ash", Companion = pikachu };
                _context.Trainers.Add(trainer);
                _context.SaveChanges();
            }
        }
    }
};

