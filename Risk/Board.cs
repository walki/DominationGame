using System;
using System.Collections.Generic;
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

        public Board()
        {

        }

        public void LoadBoard()
        {

        }

        public void CreateBoard()
        {
            Continent northAmerica = new Continent(ContinentName.NorthAmerica);
            Continent southAmerica = new Continent(ContinentName.SouthAmerica);
            Continent europe = new Continent(ContinentName.Europe);
            Continent africa = new Continent(ContinentName.Africa);
            Continent asia = new Continent(ContinentName.Asia);
            Continent australia = new Continent(ContinentName.Australia);

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

            alaska.Neighbors = new List<Country>() { kamchatka, northWestTerritory, alberta };
            northWestTerritory.Neighbors = new List<Country>() { alaska, alberta, ontario, greenland };
            greenland.Neighbors = new List<Country>() { northWestTerritory, ontario, quebec, iceland };
            alberta.Neighbors = new List<Country>() { alaska, northWestTerritory, ontario, westernUnitedStates };
            ontario.Neighbors = new List<Country>() { alberta, northWestTerritory, greenland, quebec, easternUnitedStates, westernUnitedStates };
            quebec.Neighbors = new List<Country>() { ontario, greenland, easternUnitedStates };
            westernUnitedStates.Neighbors = new List<Country>() { alberta, ontario, easternUnitedStates, centralAmerica };
            easternUnitedStates.Neighbors = new List<Country>() { westernUnitedStates, ontario, quebec, centralAmerica };
            centralAmerica.Neighbors = new List<Country>() { westernUnitedStates, easternUnitedStates, venezuela };

            venezuela.Neighbors = new List<Country>() { centralAmerica, brazil, peru };
            peru.Neighbors = new List<Country>() { venezuela, brazil, argentina };
            brazil.Neighbors = new List<Country>() { peru, venezuela, argentina };
            argentina.Neighbors = new List<Country>() { peru, brazil };

            iceland.Neighbors = new List<Country>() { greenland, scandinavia, greatBritain };
            scandinavia.Neighbors = new List<Country>() { iceland, ukraine, northernEurope, greatBritain };
            greatBritain.Neighbors = new List<Country>() { iceland, scandinavia, northernEurope, westernEurope };
            northernEurope.Neighbors = new List<Country>() { greatBritain, scandinavia, ukraine, southernEurope, westernEurope };
            ukraine.Neighbors = new List<Country>() { scandinavia, ural, afghanistan, middleEast, southernEurope, northernEurope };
            westernEurope.Neighbors = new List<Country>() { greatBritain, northernEurope, southernEurope, northAfrica };
            southernEurope.Neighbors = new List<Country>() { westernEurope, northernEurope, ukraine, middleEast, egypt, northAfrica };

            northAfrica.Neighbors = new List<Country>() { brazil, westernEurope, southernEurope, egypt, eastAfrica, congo };
            egypt.Neighbors = new List<Country>() { northAfrica, southernEurope, middleEast, eastAfrica };
            eastAfrica.Neighbors = new List<Country>() { northAfrica, egypt, middleEast, madagascar, southAfrica, congo, northAfrica };
            congo.Neighbors = new List<Country>() { northAfrica, eastAfrica, southAfrica };
            southAfrica.Neighbors = new List<Country>() { congo, eastAfrica, madagascar };
            madagascar.Neighbors = new List<Country>() { southAfrica, eastAfrica };

            ural.Neighbors = new List<Country>() { ukraine, siberia, china, afghanistan };
            siberia.Neighbors = new List<Country>() { ural, yakutsk, irkutsk, mongolia, china };
            yakutsk.Neighbors = new List<Country>() { siberia, kamchatka, irkutsk };
            kamchatka.Neighbors = new List<Country>() { yakutsk, alaska, japan, mongolia, irkutsk };
            irkutsk.Neighbors = new List<Country>() { siberia, yakutsk, kamchatka, mongolia };
            mongolia.Neighbors = new List<Country>() { siberia, irkutsk, kamchatka, japan, china };
            japan.Neighbors = new List<Country>() { mongolia, kamchatka };
            afghanistan.Neighbors = new List<Country>() { ukraine, ural, china, india, middleEast };
            china.Neighbors = new List<Country>() { afghanistan, ural, siberia, mongolia, siam, india };
            middleEast.Neighbors = new List<Country>() { southernEurope, ukraine, afghanistan, india, eastAfrica, egypt };
            india.Neighbors = new List<Country>() { middleEast, afghanistan, china, siam };
            siam.Neighbors = new List<Country>() { india, china, indonesia };

            indonesia.Neighbors = new List<Country>() { siam, newGuinea, westernAustralia };
            newGuinea.Neighbors = new List<Country>() { indonesia, easternAustralia, westernAustralia };
            westernAustralia.Neighbors = new List<Country>() { indonesia, newGuinea, easternAustralia };
            easternAustralia.Neighbors = new List<Country>() { westernAustralia, newGuinea };

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

        }

    }
}
