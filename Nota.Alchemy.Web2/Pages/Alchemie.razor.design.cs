using Microsoft.AspNetCore.Components;
using Nota.Alchemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nota.Alchemy.Web.Pages
{
    public partial class AlchemieBase : ComponentBase
    {
        protected IngredientSelection[] ingredients;
        protected AlchemieBaseData baseData;

        private void InitIngredients()
        {
            var ingredients = new[] {
new Ingredient(
                name: "Kraut",
                order:17415,
                alchemieKey: new AlchemKey(new AlchemPack( 13,8,15,15),new AlchemPack(8, 7,3,0),new AlchemPack( 8,14,0,4)),
                propertys: new[]{ "Pflanze"}
            ),
new Ingredient(
                name: "Weizen",
                order:28408,
                alchemieKey: new AlchemKey(new AlchemPack( 4,9,8,7),new AlchemPack(10, 15,6,0),new AlchemPack( 9,11,10,6)),
                propertys: new[]{ "Pflanze"}
            ),
new Ingredient(
                name: "Roggen",
                order:1667,
                alchemieKey: new AlchemKey(new AlchemPack( 15,0,11,12),new AlchemPack(3, 6,12,14),new AlchemPack( 2,12,15,14)),
                propertys: new[]{ "Pflanze"}
            ),
new Ingredient(
                name: "Gerste",
                order:61674,
                alchemieKey: new AlchemKey(new AlchemPack( 5,15,12,6),new AlchemPack(15, 1,3,2),new AlchemPack( 4,1,10,5)),
                propertys: new[]{ "Pflanze"}
            ),
new Ingredient(
                name: "Hafer",
                order:75831,
                alchemieKey: new AlchemKey(new AlchemPack( 11,7,1,2),new AlchemPack(6, 11,7,14),new AlchemPack( 3,15,0,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Triticale",
                order:85646,
                alchemieKey: new AlchemKey(new AlchemPack( 15,8,9,13),new AlchemPack(9, 8,11,0),new AlchemPack( 2,1,10,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Reis",
                order:89066,
                alchemieKey: new AlchemKey(new AlchemPack( 7,5,8,7),new AlchemPack(0, 8,14,9),new AlchemPack( 15,3,1,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Mais",
                order:43663,
                alchemieKey: new AlchemKey(new AlchemPack( 6,3,1,10),new AlchemPack(2, 10,12,11),new AlchemPack( 3,8,0,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Hirse",
                order:53601,
                alchemieKey: new AlchemKey(new AlchemPack( 12,3,15,14),new AlchemPack(15, 10,2,11),new AlchemPack( 10,2,3,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Ackerschachtelhalm (Equisetum arvense)",
                order:9437,
                alchemieKey: new AlchemKey(new AlchemPack( 10,7,7,5),new AlchemPack(2, 8,8,9),new AlchemPack( 8,10,5,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Alant (Inula helenium)",
                order:63061,
                alchemieKey: new AlchemKey(new AlchemPack( 9,4,3,6),new AlchemPack(2, 2,0,14),new AlchemPack( 15,8,6,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Andorn (Marrubium vulgare)",
                order:99402,
                alchemieKey: new AlchemKey(new AlchemPack( 11,4,14,5),new AlchemPack(4, 5,5,11),new AlchemPack( 11,1,12,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Anis (Pimpinella anisum)",
                order:66337,
                alchemieKey: new AlchemKey(new AlchemPack( 5,14,1,1),new AlchemPack(7, 9,12,11),new AlchemPack( 7,10,14,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Arnika (Arnica montana)",
                order:54306,
                alchemieKey: new AlchemKey(new AlchemPack( 5,10,7,11),new AlchemPack(15, 3,8,5),new AlchemPack( 3,0,8,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Ashitaba (Angelica keiskei )",
                order:93701,
                alchemieKey: new AlchemKey(new AlchemPack( 5,3,2,2),new AlchemPack(8, 7,15,11),new AlchemPack( 15,2,4,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Augentrost (Euphrasia officinalis)",
                order:50725,
                alchemieKey: new AlchemKey(new AlchemPack( 7,3,11,0),new AlchemPack(9, 7,7,4),new AlchemPack( 9,13,15,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Aztekisches Süßkraut (Lippia dulcis)",
                order:2289,
                alchemieKey: new AlchemKey(new AlchemPack( 12,3,15,4),new AlchemPack(15, 12,13,7),new AlchemPack( 6,15,9,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Baldrian (Valeriana officinalis)",
                order:89261,
                alchemieKey: new AlchemKey(new AlchemPack( 9,13,14,13),new AlchemPack(11, 2,2,1),new AlchemPack( 13,0,9,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Barbarakraut (Barbarea vulgaris)",
                order:62927,
                alchemieKey: new AlchemKey(new AlchemPack( 13,14,12,8),new AlchemPack(14, 11,15,9),new AlchemPack( 2,10,0,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Bärlauch (Allium ursinum)",
                order:50294,
                alchemieKey: new AlchemKey(new AlchemPack( 11,8,6,2),new AlchemPack(9, 14,9,8),new AlchemPack( 5,1,11,1)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Basilikum (Ocimum basilicum)",
                order:78966,
                alchemieKey: new AlchemKey(new AlchemPack( 15,1,4,1),new AlchemPack(10, 5,0,5),new AlchemPack( 12,6,8,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Beifuß (Artemisia vulgaris)",
                order:82906,
                alchemieKey: new AlchemKey(new AlchemPack( 2,3,12,15),new AlchemPack(9, 12,4,8),new AlchemPack( 6,7,3,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Beinwell (Symphytum officinale)",
                order:77408,
                alchemieKey: new AlchemKey(new AlchemPack( 13,1,9,15),new AlchemPack(13, 1,11,12),new AlchemPack( 9,15,8,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Bittere Schleifenblume (Iberis amara)",
                order:18790,
                alchemieKey: new AlchemKey(new AlchemPack( 10,7,5,9),new AlchemPack(12, 5,9,2),new AlchemPack( 0,0,10,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Blutwurz (Potentilla erecta)",
                order:5910,
                alchemieKey: new AlchemKey(new AlchemPack( 1,10,2,7),new AlchemPack(12, 10,7,2),new AlchemPack( 7,0,1,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Bohnenkraut (Satureja spec.)",
                order:84627,
                alchemieKey: new AlchemKey(new AlchemPack( 7,8,12,1),new AlchemPack(5, 6,12,14),new AlchemPack( 5,2,15,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Borretsch (Borago officinalis)",
                order:71157,
                alchemieKey: new AlchemKey(new AlchemPack( 3,0,9,12),new AlchemPack(8, 7,8,15),new AlchemPack( 6,14,14,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Brahmi (Bacopa monnieri)",
                order:47464,
                alchemieKey: new AlchemKey(new AlchemPack( 10,9,11,12),new AlchemPack(7, 0,9,4),new AlchemPack( 2,12,13,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Brennnessel (Urtica dioica)",
                order:95575,
                alchemieKey: new AlchemKey(new AlchemPack( 2,10,15,0),new AlchemPack(1, 14,3,11),new AlchemPack( 8,6,0,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Currykraut (Helichrysum italicum)",
                order:55630,
                alchemieKey: new AlchemKey(new AlchemPack( 4,13,8,11),new AlchemPack(2, 6,4,2),new AlchemPack( 3,2,12,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Damiana (Turnera diffusa)",
                order:66561,
                alchemieKey: new AlchemKey(new AlchemPack( 11,1,14,5),new AlchemPack(5, 13,4,10),new AlchemPack( 9,0,13,1)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Dill (Anethum graveolens)",
                order:48078,
                alchemieKey: new AlchemKey(new AlchemPack( 8,14,12,1),new AlchemPack(7, 15,6,1),new AlchemPack( 3,1,9,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Diptam Dost (Origanum dictamnus)",
                order:33296,
                alchemieKey: new AlchemKey(new AlchemPack( 9,15,7,14),new AlchemPack(10, 4,4,3),new AlchemPack( 5,2,14,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Duftveilchen (Viola odorata)",
                order:78257,
                alchemieKey: new AlchemKey(new AlchemPack( 4,9,7,4),new AlchemPack(15, 0,12,14),new AlchemPack( 3,8,13,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Eberraute (Artemisia abrotanum)",
                order:45864,
                alchemieKey: new AlchemKey(new AlchemPack( 1,0,13,2),new AlchemPack(12, 3,4,11),new AlchemPack( 3,0,5,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Echte Kamille (Matricaria recutita)",
                order:83775,
                alchemieKey: new AlchemKey(new AlchemPack( 0,7,12,10),new AlchemPack(15, 10,6,7),new AlchemPack( 5,14,8,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Ehrenpreis (Veronica officinalis)",
                order:87205,
                alchemieKey: new AlchemKey(new AlchemPack( 6,7,10,6),new AlchemPack(0, 5,5,14),new AlchemPack( 9,2,8,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Eibisch (Althaea officinalis)",
                order:47956,
                alchemieKey: new AlchemKey(new AlchemPack( 11,4,9,11),new AlchemPack(7, 4,12,1),new AlchemPack( 3,14,12,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Eisenkraut (Verbena officinalis)",
                order:63748,
                alchemieKey: new AlchemKey(new AlchemPack( 11,9,8,8),new AlchemPack(11, 15,1,10),new AlchemPack( 12,9,10,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Erdrauch (Fumaria officinalis)",
                order:8246,
                alchemieKey: new AlchemKey(new AlchemPack( 13,14,14,12),new AlchemPack(13, 7,14,3),new AlchemPack( 15,0,6,8)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Estragon (Artemisia dracunculus)",
                order:6422,
                alchemieKey: new AlchemKey(new AlchemPack( 1,4,13,12),new AlchemPack(15, 3,10,2),new AlchemPack( 12,14,11,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Fenchel (Foeniculum vulgare)",
                order:44480,
                alchemieKey: new AlchemKey(new AlchemPack( 3,8,11,3),new AlchemPack(15, 12,14,15),new AlchemPack( 12,8,9,13)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Fieberklee (Menyanthes trifoliata)",
                order:33457,
                alchemieKey: new AlchemKey(new AlchemPack( 4,7,2,9),new AlchemPack(1, 3,7,6),new AlchemPack( 6,5,13,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Frauenmantel (Alchemilla xanthochlora)",
                order:96109,
                alchemieKey: new AlchemKey(new AlchemPack( 10,10,1,7),new AlchemPack(4, 15,11,8),new AlchemPack( 6,4,3,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Gänseblümchen (Bellis perennis)",
                order:9588,
                alchemieKey: new AlchemKey(new AlchemPack( 0,15,0,12),new AlchemPack(15, 4,8,7),new AlchemPack( 4,4,3,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Gänsefingerkraut (Potentilla anserina)",
                order:8322,
                alchemieKey: new AlchemKey(new AlchemPack( 12,14,0,14),new AlchemPack(6, 1,6,1),new AlchemPack( 1,8,6,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Giersch (Aegopodium podagraria)",
                order:53325,
                alchemieKey: new AlchemKey(new AlchemPack( 9,10,2,7),new AlchemPack(14, 2,6,15),new AlchemPack( 4,10,0,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Goldmelisse (Monarda didyma)",
                order:80661,
                alchemieKey: new AlchemKey(new AlchemPack( 13,7,4,5),new AlchemPack(14, 5,14,6),new AlchemPack( 0,6,13,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Goldrute (Solidago virgaurea)",
                order:2953,
                alchemieKey: new AlchemKey(new AlchemPack( 7,12,10,14),new AlchemPack(4, 0,9,15),new AlchemPack( 15,4,15,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Gotu Kola (Centella asiatica)",
                order:2065,
                alchemieKey: new AlchemKey(new AlchemPack( 1,13,7,4),new AlchemPack(10, 14,3,6),new AlchemPack( 14,13,9,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Gundermann (Glechoma hederacea)",
                order:98267,
                alchemieKey: new AlchemKey(new AlchemPack( 0,5,2,6),new AlchemPack(6, 4,7,0),new AlchemPack( 14,3,6,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Guter Heinrich (Blitum bonus-henricus)",
                order:56400,
                alchemieKey: new AlchemKey(new AlchemPack( 10,10,8,14),new AlchemPack(14, 7,2,0),new AlchemPack( 0,11,10,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Hauhechel (Ononis spinosa)",
                order:83356,
                alchemieKey: new AlchemKey(new AlchemPack( 1,1,13,9),new AlchemPack(13, 1,13,13),new AlchemPack( 7,12,7,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Herzgespann (Leonurus cardiaca)",
                order:46753,
                alchemieKey: new AlchemKey(new AlchemPack( 10,3,12,11),new AlchemPack(3, 14,8,11),new AlchemPack( 2,7,5,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Hirtentäschel (Capsella bursa-pastoris)",
                order:36810,
                alchemieKey: new AlchemKey(new AlchemPack( 1,10,6,12),new AlchemPack(8, 14,13,1),new AlchemPack( 10,12,4,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Huflattich (Tussilago farfara)",
                order:17280,
                alchemieKey: new AlchemKey(new AlchemPack( 0,7,3,7),new AlchemPack(7, 8,0,12),new AlchemPack( 14,11,7,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Jiaogulan (Gynostemma pentaphyllum)",
                order:9165,
                alchemieKey: new AlchemKey(new AlchemPack( 11,1,1,13),new AlchemPack(0, 0,12,10),new AlchemPack( 11,9,9,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Johanniskraut (Hypericum perforatum)",
                order:63708,
                alchemieKey: new AlchemKey(new AlchemPack( 15,12,14,0),new AlchemPack(1, 6,14,12),new AlchemPack( 2,12,2,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kanadische Goldrute (Solidago canadensis)",
                order:7123,
                alchemieKey: new AlchemKey(new AlchemPack( 2,10,11,14),new AlchemPack(3, 3,1,13),new AlchemPack( 11,15,10,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kapuzinerkresse (Tropaeolum majus)",
                order:53161,
                alchemieKey: new AlchemKey(new AlchemPack( 15,12,5,1),new AlchemPack(5, 12,14,8),new AlchemPack( 2,10,9,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Karde (Dipsacus fullonum)",
                order:58142,
                alchemieKey: new AlchemKey(new AlchemPack( 11,15,9,0),new AlchemPack(0, 10,7,15),new AlchemPack( 6,4,8,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kerbel (Anthriscus cerefolium)",
                order:58642,
                alchemieKey: new AlchemKey(new AlchemPack( 9,9,4,5),new AlchemPack(14, 4,12,8),new AlchemPack( 14,5,2,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Klatschmohn (Papaver rhoeas)",
                order:88165,
                alchemieKey: new AlchemKey(new AlchemPack( 1,2,7,6),new AlchemPack(13, 4,7,1),new AlchemPack( 3,15,13,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kleines Fettblatt (Bacopa monnieri)",
                order:49774,
                alchemieKey: new AlchemKey(new AlchemPack( 2,5,1,8),new AlchemPack(3, 6,15,3),new AlchemPack( 7,6,1,1)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Klettenlabkraut (Galium aparine)",
                order:75966,
                alchemieKey: new AlchemKey(new AlchemPack( 12,3,13,3),new AlchemPack(8, 7,12,5),new AlchemPack( 11,4,12,1)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Knoblauchsrauke (Alliaria petiolata)",
                order:46344,
                alchemieKey: new AlchemKey(new AlchemPack( 15,15,5,1),new AlchemPack(7, 9,1,12),new AlchemPack( 8,12,6,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Koriander (Coriandrum sativum)",
                order:68263,
                alchemieKey: new AlchemKey(new AlchemPack( 14,13,9,13),new AlchemPack(11, 5,4,3),new AlchemPack( 10,12,1,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kornblume (Centaurea cyanus)",
                order:62514,
                alchemieKey: new AlchemKey(new AlchemPack( 0,12,3,5),new AlchemPack(15, 3,4,4),new AlchemPack( 9,11,12,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Küchenschelle (Pulsatilla vulgaris)",
                order:52906,
                alchemieKey: new AlchemKey(new AlchemPack( 9,10,5,10),new AlchemPack(5, 11,11,4),new AlchemPack( 11,0,6,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kümmel (Carum carvi)",
                order:13635,
                alchemieKey: new AlchemKey(new AlchemPack( 0,6,3,13),new AlchemPack(0, 15,5,2),new AlchemPack( 0,2,1,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Lavendel (Lavandula angustifolia)",
                order:13099,
                alchemieKey: new AlchemKey(new AlchemPack( 13,14,14,2),new AlchemPack(11, 8,14,7),new AlchemPack( 7,0,4,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Lein (Linum usitatissimum)",
                order:62861,
                alchemieKey: new AlchemKey(new AlchemPack( 3,4,15,11),new AlchemPack(11, 8,4,0),new AlchemPack( 5,15,7,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Liebstöckel (Levisticum officinale)",
                order:20468,
                alchemieKey: new AlchemKey(new AlchemPack( 11,1,2,11),new AlchemPack(9, 5,3,2),new AlchemPack( 14,3,2,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Löwenzahn (Taraxacum officinale)",
                order:67945,
                alchemieKey: new AlchemKey(new AlchemPack( 5,1,14,14),new AlchemPack(11, 12,11,3),new AlchemPack( 11,1,10,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Lungenkraut (Pulmonaria officinalis)",
                order:41814,
                alchemieKey: new AlchemKey(new AlchemPack( 7,1,10,10),new AlchemPack(13, 12,2,1),new AlchemPack( 10,6,15,13)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Mädesüß (Filipendula ulmaria)",
                order:50517,
                alchemieKey: new AlchemKey(new AlchemPack( 6,6,15,4),new AlchemPack(10, 0,13,11),new AlchemPack( 13,3,14,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Majoran (Origanum majorana)",
                order:84758,
                alchemieKey: new AlchemKey(new AlchemPack( 9,7,8,8),new AlchemPack(5, 11,0,1),new AlchemPack( 7,9,4,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Malve (Malva sylvestris)",
                order:63135,
                alchemieKey: new AlchemKey(new AlchemPack( 10,2,6,12),new AlchemPack(15, 0,6,3),new AlchemPack( 9,2,6,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Mariendistel (Silybum marianum)",
                order:61288,
                alchemieKey: new AlchemKey(new AlchemPack( 14,0,14,6),new AlchemPack(13, 8,13,6),new AlchemPack( 4,13,15,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Mönchspfeffer (Vitex agnus-castus)",
                order:42348,
                alchemieKey: new AlchemKey(new AlchemPack( 0,2,13,8),new AlchemPack(6, 13,4,5),new AlchemPack( 1,14,0,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Mutterkraut (Tanacetum parthenium)",
                order:83637,
                alchemieKey: new AlchemKey(new AlchemPack( 4,11,0,4),new AlchemPack(10, 7,0,8),new AlchemPack( 4,6,3,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Nachtkerze (Oenothera biennis)",
                order:17824,
                alchemieKey: new AlchemKey(new AlchemPack( 5,1,0,6),new AlchemPack(0, 0,0,14),new AlchemPack( 12,13,5,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Natternkopf (Echium vulgare)",
                order:10404,
                alchemieKey: new AlchemKey(new AlchemPack( 9,11,2,4),new AlchemPack(14, 7,6,13),new AlchemPack( 13,15,10,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Odermennig (Agrimonia eupatoria)",
                order:3680,
                alchemieKey: new AlchemKey(new AlchemPack( 11,15,1,14),new AlchemPack(12, 14,7,6),new AlchemPack( 5,10,12,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Olivenkraut (Santolina viridis)",
                order:94977,
                alchemieKey: new AlchemKey(new AlchemPack( 14,15,14,0),new AlchemPack(11, 9,10,15),new AlchemPack( 12,9,3,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Oregano (Origanum vulgare)",
                order:62213,
                alchemieKey: new AlchemKey(new AlchemPack( 4,6,15,4),new AlchemPack(15, 4,8,8),new AlchemPack( 10,9,6,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Perilla (Perilla frutescens)",
                order:5270,
                alchemieKey: new AlchemKey(new AlchemPack( 6,7,14,4),new AlchemPack(1, 15,2,10),new AlchemPack( 6,5,1,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Petersilie (Petroselinum crispum)",
                order:82013,
                alchemieKey: new AlchemKey(new AlchemPack( 8,9,13,13),new AlchemPack(4, 15,1,14),new AlchemPack( 15,13,5,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Pfefferminze (Mentha x piperita)",
                order:98299,
                alchemieKey: new AlchemKey(new AlchemPack( 9,3,3,4),new AlchemPack(15, 15,2,1),new AlchemPack( 13,0,1,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Pilzkraut (Rungia klossii)",
                order:65708,
                alchemieKey: new AlchemKey(new AlchemPack( 6,1,15,10),new AlchemPack(6, 4,4,8),new AlchemPack( 11,9,10,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Pimpinelle (Sanguisorba minor)",
                order:31945,
                alchemieKey: new AlchemKey(new AlchemPack( 5,4,7,10),new AlchemPack(1, 4,0,9),new AlchemPack( 10,1,7,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Quendel (Thymus pulegioides)",
                order:95202,
                alchemieKey: new AlchemKey(new AlchemPack( 8,13,4,8),new AlchemPack(15, 1,9,9),new AlchemPack( 0,13,15,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Ringelblume (Calandula officinalis)",
                order:79873,
                alchemieKey: new AlchemKey(new AlchemPack( 8,2,12,3),new AlchemPack(1, 7,15,12),new AlchemPack( 13,5,14,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Rosmarin (Rosmarinus officinalis)",
                order:74538,
                alchemieKey: new AlchemKey(new AlchemPack( 2,1,0,2),new AlchemPack(14, 15,15,14),new AlchemPack( 0,9,7,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Rotklee (Trifolium pratense)",
                order:58757,
                alchemieKey: new AlchemKey(new AlchemPack( 14,9,2,7),new AlchemPack(12, 11,0,13),new AlchemPack( 4,13,11,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Salbei (Salvia officinalis)",
                order:12462,
                alchemieKey: new AlchemKey(new AlchemPack( 8,6,3,6),new AlchemPack(11, 5,5,1),new AlchemPack( 9,15,11,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Sauerampfer (Rumex acetosa)",
                order:56112,
                alchemieKey: new AlchemKey(new AlchemPack( 10,4,10,11),new AlchemPack(3, 6,5,6),new AlchemPack( 6,0,3,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Schafgarbe (Achillea millefolium )",
                order:74238,
                alchemieKey: new AlchemKey(new AlchemPack( 12,4,1,13),new AlchemPack(3, 1,4,14),new AlchemPack( 15,1,4,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Scharbockskraut (Ficaria verna)",
                order:11041,
                alchemieKey: new AlchemKey(new AlchemPack( 5,5,1,2),new AlchemPack(2, 0,4,7),new AlchemPack( 4,11,10,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Schlüsselblume (Primula veris)",
                order:71449,
                alchemieKey: new AlchemKey(new AlchemPack( 5,3,5,4),new AlchemPack(12, 11,10,4),new AlchemPack( 1,13,5,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Schnittlauch (Allium schoenoprasum)",
                order:8634,
                alchemieKey: new AlchemKey(new AlchemPack( 15,3,1,13),new AlchemPack(7, 9,3,5),new AlchemPack( 0,12,7,13)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Schöllkraut (Chelidonium majus)",
                order:27103,
                alchemieKey: new AlchemKey(new AlchemPack( 7,15,11,3),new AlchemPack(7, 4,9,6),new AlchemPack( 10,9,8,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Schwarzkümmel (Nigella sativa)",
                order:21693,
                alchemieKey: new AlchemKey(new AlchemPack( 3,11,4,11),new AlchemPack(15, 13,11,7),new AlchemPack( 15,10,2,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Seifenkraut (Saponaria officinalis)",
                order:90914,
                alchemieKey: new AlchemKey(new AlchemPack( 4,11,10,5),new AlchemPack(4, 14,4,9),new AlchemPack( 6,6,5,1)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Shiso (Perilla frutescens)",
                order:82448,
                alchemieKey: new AlchemKey(new AlchemPack( 11,13,6,11),new AlchemPack(12, 12,0,4),new AlchemPack( 4,12,0,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Sonnenhut (Echinacea spec.)",
                order:28182,
                alchemieKey: new AlchemKey(new AlchemPack( 10,8,1,1),new AlchemPack(4, 3,4,14),new AlchemPack( 14,0,14,13)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Spitzwegerich (Plantago lanceolata)",
                order:14018,
                alchemieKey: new AlchemKey(new AlchemPack( 13,12,3,9),new AlchemPack(11, 1,6,8),new AlchemPack( 8,4,4,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Stevia (Stevia rebaudiana)",
                order:74877,
                alchemieKey: new AlchemKey(new AlchemPack( 5,8,1,10),new AlchemPack(3, 10,15,12),new AlchemPack( 12,14,1,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Süßholz (Glycyrrhiza glabra)",
                order:5365,
                alchemieKey: new AlchemKey(new AlchemPack( 5,6,5,13),new AlchemPack(1, 8,14,12),new AlchemPack( 11,8,12,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Taigawurzel (Eleutherococcus senticosus)",
                order:7551,
                alchemieKey: new AlchemKey(new AlchemPack( 12,13,15,8),new AlchemPack(6, 12,10,12),new AlchemPack( 9,12,11,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Tausendgüldenkraut (Centaurium erythraea)",
                order:51238,
                alchemieKey: new AlchemKey(new AlchemPack( 7,15,3,3),new AlchemPack(15, 6,0,13),new AlchemPack( 12,4,15,8)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Teufelskralle (Harpagophytum procumbens)",
                order:91269,
                alchemieKey: new AlchemKey(new AlchemPack( 14,15,12,12),new AlchemPack(15, 11,5,7),new AlchemPack( 8,8,3,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Thymian (Thymus vulgaris)",
                order:894,
                alchemieKey: new AlchemKey(new AlchemPack( 2,13,4,11),new AlchemPack(12, 2,12,6),new AlchemPack( 4,6,15,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Tripmadam (Sedum rupestre, Sedum reflexum)",
                order:70007,
                alchemieKey: new AlchemKey(new AlchemPack( 11,7,7,3),new AlchemPack(15, 11,3,5),new AlchemPack( 2,12,7,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Tulsi (Ocimum tenuiflorum)",
                order:36807,
                alchemieKey: new AlchemKey(new AlchemPack( 8,7,3,7),new AlchemPack(0, 3,1,11),new AlchemPack( 13,4,13,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Vietnamesischer Koriander (Persicaria odorata)",
                order:77931,
                alchemieKey: new AlchemKey(new AlchemPack( 14,11,1,2),new AlchemPack(8, 12,1,3),new AlchemPack( 2,2,6,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Vogelmiere (Stellaria media)",
                order:15176,
                alchemieKey: new AlchemKey(new AlchemPack( 14,10,5,11),new AlchemPack(12, 12,12,2),new AlchemPack( 12,14,15,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Waldmeister (Galium odoratum)",
                order:1197,
                alchemieKey: new AlchemKey(new AlchemPack( 12,4,6,8),new AlchemPack(0, 4,9,2),new AlchemPack( 12,9,14,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Wegwarte (Cichorium intybus)",
                order:95076,
                alchemieKey: new AlchemKey(new AlchemPack( 2,4,10,13),new AlchemPack(13, 0,12,1),new AlchemPack( 10,10,3,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Weinraute (Ruta graveolens)",
                order:38090,
                alchemieKey: new AlchemKey(new AlchemPack( 2,9,9,6),new AlchemPack(14, 0,10,11),new AlchemPack( 10,13,10,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Weiße Taubnessel (Lamium album)",
                order:43188,
                alchemieKey: new AlchemKey(new AlchemPack( 13,6,1,7),new AlchemPack(2, 14,1,5),new AlchemPack( 3,12,5,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Wermut (Artemisia absinthium)",
                order:97946,
                alchemieKey: new AlchemKey(new AlchemPack( 0,9,12,3),new AlchemPack(12, 8,3,11),new AlchemPack( 7,12,10,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Wiesenknopf (Sanguisorba officinalis)",
                order:10396,
                alchemieKey: new AlchemKey(new AlchemPack( 0,12,8,11),new AlchemPack(0, 7,11,13),new AlchemPack( 2,7,2,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Wilde Möhre (Daucus carota subsp. carota)",
                order:93093,
                alchemieKey: new AlchemKey(new AlchemPack( 4,8,2,7),new AlchemPack(13, 4,6,8),new AlchemPack( 4,15,5,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Ysop (Hyssopus officinalis)",
                order:37619,
                alchemieKey: new AlchemKey(new AlchemPack( 1,9,3,8),new AlchemPack(2, 8,11,2),new AlchemPack( 4,6,11,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Zitronenmelisse (Melissa officinalis)",
                order:2268,
                alchemieKey: new AlchemKey(new AlchemPack( 0,1,11,6),new AlchemPack(14, 2,2,15),new AlchemPack( 14,5,8,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Zitronenverbene (Aloysia citrodora)",
                order:76737,
                alchemieKey: new AlchemKey(new AlchemPack( 6,13,7,0),new AlchemPack(13, 3,13,4),new AlchemPack( 3,12,3,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Aluminium",
                order:41217,
                alchemieKey: new AlchemKey(new AlchemPack( 4,3,3,12),new AlchemPack(12, 2,9,10),new AlchemPack( 8,5,5,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Berylium",
                order:91876,
                alchemieKey: new AlchemKey(new AlchemPack( 5,11,1,14),new AlchemPack(5, 15,4,11),new AlchemPack( 1,12,1,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Bismut",
                order:79484,
                alchemieKey: new AlchemKey(new AlchemPack( 4,0,10,15),new AlchemPack(9, 1,8,13),new AlchemPack( 5,15,12,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Blei",
                order:74333,
                alchemieKey: new AlchemKey(new AlchemPack( 0,9,14,6),new AlchemPack(14, 13,2,2),new AlchemPack( 4,4,3,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Cadmium",
                order:90406,
                alchemieKey: new AlchemKey(new AlchemPack( 7,11,7,0),new AlchemPack(14, 10,7,4),new AlchemPack( 13,13,6,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Chrom",
                order:8321,
                alchemieKey: new AlchemKey(new AlchemPack( 15,7,9,7),new AlchemPack(10, 14,10,6),new AlchemPack( 12,1,4,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Eisenkraut (Verbena officinalis)",
                order:12662,
                alchemieKey: new AlchemKey(new AlchemPack( 14,4,7,4),new AlchemPack(13, 3,11,9),new AlchemPack( 2,10,3,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Gallium",
                order:33271,
                alchemieKey: new AlchemKey(new AlchemPack( 11,8,0,7),new AlchemPack(10, 14,2,15),new AlchemPack( 13,6,2,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Gold",
                order:41541,
                alchemieKey: new AlchemKey(new AlchemPack( 5,5,0,8),new AlchemPack(7, 6,2,2),new AlchemPack( 5,3,12,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Indium",
                order:18472,
                alchemieKey: new AlchemKey(new AlchemPack( 5,2,2,11),new AlchemPack(4, 7,3,14),new AlchemPack( 14,15,6,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Iridium",
                order:10760,
                alchemieKey: new AlchemKey(new AlchemPack( 6,8,0,3),new AlchemPack(13, 2,5,5),new AlchemPack( 5,7,10,13)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kalium",
                order:19642,
                alchemieKey: new AlchemKey(new AlchemPack( 6,11,3,0),new AlchemPack(1, 9,15,12),new AlchemPack( 5,11,0,7)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Cobalt",
                order:42782,
                alchemieKey: new AlchemKey(new AlchemPack( 10,10,7,13),new AlchemPack(7, 14,14,12),new AlchemPack( 11,0,15,8)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Kupfer",
                order:2436,
                alchemieKey: new AlchemKey(new AlchemPack( 8,2,13,4),new AlchemPack(9, 10,3,11),new AlchemPack( 5,14,14,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Magnesium",
                order:40536,
                alchemieKey: new AlchemKey(new AlchemPack( 10,5,2,11),new AlchemPack(15, 11,11,15),new AlchemPack( 4,7,12,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Mangan",
                order:91522,
                alchemieKey: new AlchemKey(new AlchemPack( 15,10,10,13),new AlchemPack(11, 14,4,12),new AlchemPack( 0,1,10,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Molybdän",
                order:15577,
                alchemieKey: new AlchemKey(new AlchemPack( 13,5,0,7),new AlchemPack(1, 7,11,5),new AlchemPack( 2,11,14,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Natrium",
                order:37042,
                alchemieKey: new AlchemKey(new AlchemPack( 14,5,9,9),new AlchemPack(12, 12,13,10),new AlchemPack( 6,9,6,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Nickel",
                order:32840,
                alchemieKey: new AlchemKey(new AlchemPack( 11,14,1,3),new AlchemPack(1, 8,8,7),new AlchemPack( 14,7,3,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Osmium",
                order:10378,
                alchemieKey: new AlchemKey(new AlchemPack( 6,1,10,4),new AlchemPack(15, 4,9,2),new AlchemPack( 2,14,10,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Palladium",
                order:80369,
                alchemieKey: new AlchemKey(new AlchemPack( 2,5,0,5),new AlchemPack(14, 15,7,12),new AlchemPack( 0,13,11,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Platin",
                order:19971,
                alchemieKey: new AlchemKey(new AlchemPack( 2,15,14,11),new AlchemPack(0, 0,9,9),new AlchemPack( 5,14,14,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Quecksilber",
                order:76503,
                alchemieKey: new AlchemKey(new AlchemPack( 14,8,5,1),new AlchemPack(0, 14,15,11),new AlchemPack( 11,5,5,0)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Rhodium",
                order:68500,
                alchemieKey: new AlchemKey(new AlchemPack( 6,15,2,8),new AlchemPack(7, 11,12,0),new AlchemPack( 6,15,9,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "uthenium",
                order:91531,
                alchemieKey: new AlchemKey(new AlchemPack( 1,4,0,0),new AlchemPack(15, 7,14,5),new AlchemPack( 14,1,14,11)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Silber",
                order:654,
                alchemieKey: new AlchemKey(new AlchemPack( 14,3,5,14),new AlchemPack(5, 2,0,12),new AlchemPack( 11,0,0,13)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Tantal",
                order:95774,
                alchemieKey: new AlchemKey(new AlchemPack( 11,14,7,6),new AlchemPack(15, 10,5,11),new AlchemPack( 15,1,6,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Titan",
                order:94489,
                alchemieKey: new AlchemKey(new AlchemPack( 3,5,4,13),new AlchemPack(1, 4,3,7),new AlchemPack( 10,7,10,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Uran",
                order:39444,
                alchemieKey: new AlchemKey(new AlchemPack( 7,9,11,15),new AlchemPack(10, 6,9,9),new AlchemPack( 1,12,0,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Vanadium",
                order:63426,
                alchemieKey: new AlchemKey(new AlchemPack( 7,2,15,10),new AlchemPack(11, 7,3,3),new AlchemPack( 8,2,14,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Wolfram",
                order:47986,
                alchemieKey: new AlchemKey(new AlchemPack( 15,13,11,2),new AlchemPack(8, 12,10,11),new AlchemPack( 14,9,11,8)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Zink",
                order:27939,
                alchemieKey: new AlchemKey(new AlchemPack( 3,5,6,8),new AlchemPack(0, 9,5,15),new AlchemPack( 7,7,7,2)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Zinn",
                order:675,
                alchemieKey: new AlchemKey(new AlchemPack( 12,6,1,8),new AlchemPack(13, 2,2,0),new AlchemPack( 2,8,9,14)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Zirconium",
                order:88118,
                alchemieKey: new AlchemKey(new AlchemPack( 14,5,1,7),new AlchemPack(3, 9,0,5),new AlchemPack( 7,11,2,5)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Albit",
                order:29072,
                alchemieKey: new AlchemKey(new AlchemPack( 7,3,5,11),new AlchemPack(5, 12,7,7),new AlchemPack( 6,13,2,10)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Bergkristall",
                order:15698,
                alchemieKey: new AlchemKey(new AlchemPack( 8,15,5,0),new AlchemPack(0, 3,6,13),new AlchemPack( 13,1,11,12)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Beryllonit",
                order:99716,
                alchemieKey: new AlchemKey(new AlchemPack( 10,12,3,7),new AlchemPack(9, 12,3,0),new AlchemPack( 10,6,13,1)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Diamant",
                order:30317,
                alchemieKey: new AlchemKey(new AlchemPack( 1,12,3,2),new AlchemPack(3, 15,0,2),new AlchemPack( 11,9,7,4)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Goshenit",
                order:97029,
                alchemieKey: new AlchemKey(new AlchemPack( 9,10,5,9),new AlchemPack(9, 7,11,12),new AlchemPack( 6,14,14,15)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Hambergit",
                order:63867,
                alchemieKey: new AlchemKey(new AlchemPack( 6,1,2,8),new AlchemPack(9, 4,0,13),new AlchemPack( 12,3,14,6)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Leucit",
                order:88205,
                alchemieKey: new AlchemKey(new AlchemPack( 2,9,5,4),new AlchemPack(15, 12,1,1),new AlchemPack( 15,12,1,3)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Petalit",
                order:55796,
                alchemieKey: new AlchemKey(new AlchemPack( 12,3,2,12),new AlchemPack(12, 5,5,15),new AlchemPack( 5,6,7,9)),
                propertys: new HashSet<string>()
            ),
new Ingredient(
                name: "Phenakit",
                order:8740,
                alchemieKey: new AlchemKey(new AlchemPack( 10,12,8,3),new AlchemPack(5, 4,12,15),new AlchemPack( 11,2,14,9)),
                propertys: new HashSet<string>()
            ),


        };

            this.baseData = new AlchemieBaseData(ingredients, new IngredientProcessing[] {

                new IngredientProcessing("Zerkleiner", 3,2,1,0,7,6,5,4,11,10,9,8, "Pflanze")
            });

            this.ingredients = ingredients.Select(x => new IngredientSelection(x)).ToArray();
        }


    }
}
