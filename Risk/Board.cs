using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Board
    {
        List<Continent> Continents
        {
            get;
            set;
        }

        Dictionary<CountryName, Country> AllCountries
        {
            get;
            set;
        }

        public Board()
        {

        }

        public void LoadBoard()
        {
            using (StreamReader sr = new StreamReader("C:\\users\\roger\\desktop\\json.txt"))
            {
                string json = sr.ReadToEnd();
                Continents = JsonConvert.DeserializeObject<List<Continent>>(json);
            }
            FillAllCountries();
        }

        public void WriteBoard()
        {
            using (StreamWriter sw = new StreamWriter("C:\\users\\roger\\desktop\\json.txt"))
            {
                string json = JsonConvert.SerializeObject(Continents, Formatting.Indented);       
                sw.WriteLine(json);
                
            }
        }

        public void CreateBoard()
        {
            Continent northAmerica = new Continent(ContinentName.NorthAmerica, 5);
            Continent southAmerica = new Continent(ContinentName.SouthAmerica, 2);
            Continent europe = new Continent(ContinentName.Europe, 5);
            Continent africa = new Continent(ContinentName.Africa, 3);
            Continent asia = new Continent(ContinentName.Asia, 7);
            Continent australia = new Continent(ContinentName.Australia, 2);

            Country alaska = new Country(CountryName.Alaska);
            Country northWestTerritory = new Country(CountryName.NorthWestTerritory);
            Country greenland = new Country(CountryName.Greenland);
            Country alberta = new Country(CountryName.Alberta);
            Country ontario = new Country(CountryName.Ontario);
            Country quebec = new Country(CountryName.Quebec);
            Country westernUnitedStates = new Country(CountryName.WesternUnitedStates);
            Country easternUnitedStates = new Country(CountryName.EasternUnitedStates);
            Country centralAmerica = new Country(CountryName.CentralAmerica);

            Country venezuela = new Country(CountryName.Venezuela);
            Country peru = new Country(CountryName.Peru);
            Country brazil = new Country(CountryName.Brazil);
            Country argentina = new Country(CountryName.Argentina);

            Country iceland = new Country(CountryName.Iceland);
            Country scandinavia = new Country(CountryName.Scandinavia);
            Country greatBritain = new Country(CountryName.GreatBritain);
            Country northernEurope = new Country(CountryName.NorthernEurope);
            Country ukraine = new Country(CountryName.Ukraine);
            Country westernEurope = new Country(CountryName.WesternEurope);
            Country southernEurope = new Country(CountryName.SouthernEurope);

            Country northAfrica = new Country(CountryName.NorthAfrica);
            Country egypt = new Country(CountryName.Egypt);
            Country eastAfrica = new Country(CountryName.EastAfrica);
            Country congo = new Country(CountryName.Congo);
            Country southAfrica = new Country(CountryName.SouthAfrica);
            Country madagascar = new Country(CountryName.Madagascar);

            Country ural = new Country(CountryName.Ural);
            Country siberia = new Country(CountryName.Siberia);
            Country yakutsk = new Country(CountryName.Yakutsk);
            Country kamchatka = new Country(CountryName.Kamchatka);
            Country irkutsk = new Country(CountryName.Irkutsk);
            Country mongolia = new Country(CountryName.Mongolia);
            Country japan = new Country(CountryName.Japan);
            Country afghanistan = new Country(CountryName.Afghanistan);
            Country china = new Country(CountryName.China);
            Country middleEast = new Country(CountryName.MiddleEast);
            Country india = new Country(CountryName.India);
            Country siam = new Country(CountryName.Siam);

            Country indonesia = new Country(CountryName.Indonesia);
            Country newGuinea = new Country(CountryName.NewGuinea);
            Country westernAustralia = new Country(CountryName.WesternAustralia);
            Country easternAustralia = new Country(CountryName.EasternAustralia);

            alaska.Neighbors = new List<CountryName>() { CountryName.Kamchatka, CountryName.NorthWestTerritory, CountryName.Alberta };
            northWestTerritory.Neighbors = new List<CountryName>() { CountryName.Alaska, CountryName.Alberta, CountryName.Ontario, CountryName.Greenland };
            greenland.Neighbors = new List<CountryName>() { CountryName.NorthWestTerritory, CountryName.Ontario, CountryName.Quebec, CountryName.Iceland };
            alberta.Neighbors = new List<CountryName>() { CountryName.Alaska, CountryName.NorthWestTerritory, CountryName.Ontario, CountryName.WesternUnitedStates };
            ontario.Neighbors = new List<CountryName>() { CountryName.Alberta, CountryName.NorthWestTerritory, CountryName.Greenland, CountryName.Quebec, CountryName.EasternUnitedStates, CountryName.WesternUnitedStates };
            quebec.Neighbors = new List<CountryName>() { CountryName.Ontario, CountryName.Greenland, CountryName.EasternUnitedStates };
            westernUnitedStates.Neighbors = new List<CountryName>() { CountryName.Alberta, CountryName.Ontario, CountryName.EasternUnitedStates, CountryName.CentralAmerica };
            easternUnitedStates.Neighbors = new List<CountryName>() { CountryName.WesternUnitedStates, CountryName.Ontario, CountryName.Quebec, CountryName.CentralAmerica };
            centralAmerica.Neighbors = new List<CountryName>() { CountryName.WesternUnitedStates, CountryName.EasternUnitedStates, CountryName.Venezuela };

            venezuela.Neighbors = new List<CountryName>() { CountryName.CentralAmerica, CountryName.Brazil, CountryName.Peru };
            peru.Neighbors = new List<CountryName>() { CountryName.Venezuela, CountryName.Brazil, CountryName.Argentina };
            brazil.Neighbors = new List<CountryName>() { CountryName.Peru, CountryName.Venezuela, CountryName.Argentina, CountryName.NorthAfrica };
            argentina.Neighbors = new List<CountryName>() { CountryName.Peru, CountryName.Brazil };

            iceland.Neighbors = new List<CountryName>() { CountryName.Greenland, CountryName.Scandinavia, CountryName.GreatBritain };
            scandinavia.Neighbors = new List<CountryName>() { CountryName.Iceland, CountryName.Ukraine, CountryName.NorthernEurope, CountryName.GreatBritain };
            greatBritain.Neighbors = new List<CountryName>() { CountryName.Iceland, CountryName.Scandinavia, CountryName.NorthernEurope, CountryName.WesternEurope };
            northernEurope.Neighbors = new List<CountryName>() { CountryName.GreatBritain, CountryName.Scandinavia, CountryName.Ukraine, CountryName.SouthernEurope, CountryName.WesternEurope };
            ukraine.Neighbors = new List<CountryName>() { CountryName.Scandinavia, CountryName.Ural, CountryName.Afghanistan, CountryName.MiddleEast, CountryName.SouthernEurope, CountryName.NorthernEurope };
            westernEurope.Neighbors = new List<CountryName>() { CountryName.GreatBritain, CountryName.NorthernEurope, CountryName.SouthernEurope, CountryName.NorthAfrica };
            southernEurope.Neighbors = new List<CountryName>() { CountryName.WesternEurope, CountryName.NorthernEurope, CountryName.Ukraine, CountryName.MiddleEast, CountryName.Egypt, CountryName.NorthAfrica };

            northAfrica.Neighbors = new List<CountryName>() { CountryName.Brazil, CountryName.WesternEurope, CountryName.SouthernEurope, CountryName.Egypt, CountryName.EastAfrica, CountryName.Congo };
            egypt.Neighbors = new List<CountryName>() { CountryName.NorthAfrica, CountryName.SouthernEurope, CountryName.MiddleEast, CountryName.EastAfrica };
            eastAfrica.Neighbors = new List<CountryName>() { CountryName.NorthAfrica, CountryName.Egypt, CountryName.MiddleEast, CountryName.Madagascar, CountryName.SouthAfrica, CountryName.Congo };
            congo.Neighbors = new List<CountryName>() { CountryName.NorthAfrica, CountryName.EastAfrica, CountryName.SouthAfrica };
            southAfrica.Neighbors = new List<CountryName>() { CountryName.Congo, CountryName.EastAfrica, CountryName.Madagascar };
            madagascar.Neighbors = new List<CountryName>() { CountryName.SouthAfrica, CountryName.EastAfrica };

            ural.Neighbors = new List<CountryName>() { CountryName.Ukraine, CountryName.Siberia, CountryName.China, CountryName.Afghanistan };
            siberia.Neighbors = new List<CountryName>() { CountryName.Ural, CountryName.Yakutsk, CountryName.Irkutsk, CountryName.Mongolia, CountryName.China };
            yakutsk.Neighbors = new List<CountryName>() { CountryName.Siberia, CountryName.Kamchatka, CountryName.Irkutsk };
            kamchatka.Neighbors = new List<CountryName>() { CountryName.Yakutsk, CountryName.Alaska, CountryName.Japan, CountryName.Mongolia, CountryName.Irkutsk };
            irkutsk.Neighbors = new List<CountryName>() { CountryName.Siberia, CountryName.Yakutsk, CountryName.Kamchatka, CountryName.Mongolia };
            mongolia.Neighbors = new List<CountryName>() { CountryName.Siberia, CountryName.Irkutsk, CountryName.Kamchatka, CountryName.Japan, CountryName.China };
            japan.Neighbors = new List<CountryName>() { CountryName.Mongolia, CountryName.Kamchatka };
            afghanistan.Neighbors = new List<CountryName>() { CountryName.Ukraine, CountryName.Ural, CountryName.China, CountryName.India, CountryName.MiddleEast };
            china.Neighbors = new List<CountryName>() { CountryName.Afghanistan, CountryName.Ural, CountryName.Siberia, CountryName.Mongolia, CountryName.Siam, CountryName.India };
            middleEast.Neighbors = new List<CountryName>() { CountryName.SouthernEurope, CountryName.Ukraine, CountryName.Afghanistan, CountryName.India, CountryName.EastAfrica, CountryName.Egypt };
            india.Neighbors = new List<CountryName>() { CountryName.MiddleEast, CountryName.Afghanistan, CountryName.China, CountryName.Siam };
            siam.Neighbors = new List<CountryName>() { CountryName.India, CountryName.China, CountryName.Indonesia };

            indonesia.Neighbors = new List<CountryName>() { CountryName.Siam, CountryName.NewGuinea, CountryName.WesternAustralia };
            newGuinea.Neighbors = new List<CountryName>() { CountryName.Indonesia, CountryName.EasternAustralia, CountryName.WesternAustralia };
            westernAustralia.Neighbors = new List<CountryName>() { CountryName.Indonesia, CountryName.NewGuinea, CountryName.EasternAustralia };
            easternAustralia.Neighbors = new List<CountryName>() { CountryName.WesternAustralia, CountryName.NewGuinea };
            

            northAmerica.Countries = new List<Country>() { alaska, northWestTerritory, greenland,
                                                            alberta, ontario, quebec,
                                                            westernUnitedStates, easternUnitedStates, centralAmerica };

            southAmerica.Countries = new List<Country>() { venezuela, peru, brazil, argentina };

            europe.Countries = new List<Country>() { iceland, greatBritain, scandinavia, ukraine,
                                                        westernEurope, northernEurope, southernEurope };

            africa.Countries = new List<Country>() { northAfrica, egypt, eastAfrica,
                                                        congo, southAfrica, madagascar };

            asia.Countries = new List<Country>() { ural, siberia, yakutsk, kamchatka, irkutsk, mongolia,
                                                    japan, afghanistan, china, middleEast, india, siam };

            australia.Countries = new List<Country>() { indonesia, newGuinea, westernAustralia, easternAustralia };


            Continents = new List<Continent>() { northAmerica, southAmerica, europe, africa, asia, australia };

            FillAllCountries();
        }

        public void FillAllCountries()
        {
            AllCountries = new Dictionary<CountryName, Country>();
            foreach (Continent continent in Continents)
            {
                foreach (Country country in continent.Countries)
                {
                    AllCountries.Add(country.Id, country);
                }
            }
        }

        public bool ValidateCountryNeighbors()
        {
            bool valid = true;
            foreach (Country countryA in AllCountries.Values)
            {
                foreach(CountryName countryBId in countryA.Neighbors)
                {
                    Country countryB = AllCountries[countryBId];
                    if (countryB != null && countryB.Neighbors.Exists(x => x == countryA.Id))
                    {

                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
            return valid;
        }

    }
}
