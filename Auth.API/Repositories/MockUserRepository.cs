using Auth.Demo.Models;
using Auth.Demo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Demo.Repositories
{
    public class MockUserRepository : IUserRepository
    {
        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
			return _usersList;
        }

        public User GetById(int id)
        {
			return _usersList.FirstOrDefault(w => w.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }



        private readonly IEnumerable<User> _usersList = new [] {
													new User { Id = 1, Name = "Tiger Cochran", Email = "in@Integervulputate.ca", Username = "O..Roth", Password = "QKH32FPV3QC" },
													new User { Id = 2, Name = "Lars Bullock", Email = "adipiscing@Nuncullamcorper.com", Username = "B..Daniels", Password = "YPM28OGO4XR" },
													new User { Id = 3, Name = "Lillian Riley", Email = "orci.Phasellus.dapibus@volutpat.co.uk", Username = "S..Huber", Password = "CWY17VZR8KO" },
													new User { Id = 4, Name = "Lance Wilcox", Email = "Nam@orciconsectetuereuismod.com", Username = "I..Rowe", Password = "WIX46KJL5DE" },
													new User { Id = 5, Name = "Ava Petty", Email = "fringilla.porttitor@feugiat.net", Username = "Z..Thomas", Password = "GLU48ZYR3VS" },
													new User { Id = 6, Name = "Alma Charles", Email = "metus@tempuseuligula.net", Username = "F..Good", Password = "MUV00AOM8JI" },
													new User { Id = 7, Name = "Hadassah Nelson", Email = "metus@ultriciesadipiscing.net", Username = "D..Reed", Password = "CIP41YNA1GT" },
													new User { Id = 8, Name = "Peter Padilla", Email = "pellentesque@nequeSed.org", Username = "F..Golden", Password = "MIS13BFS5SM" },
													new User { Id = 9, Name = "Ronan Tyson", Email = "nisl.Nulla.eu@ipsum.net", Username = "G..Terry", Password = "ECZ62ZDM3FJ" },
													new User { Id = 10, Name = "Jessica Middleton", Email = "id.risus@dui.co.uk", Username = "M..Blake", Password = "OIH21PBO8UI" },
													new User { Id = 11, Name = "Colton Carver", Email = "Ut.sagittis@lorem.ca", Username = "V..Foster", Password = "IXL61CGR0UD" },
													new User { Id = 12, Name = "Cleo Aguilar", Email = "viverra.Maecenas@ultricesDuisvolutpat.org", Username = "D..Valentine", Password = "YKF63ULL7FQ" },
													new User { Id = 13, Name = "Faith Alston", Email = "consectetuer.cursus@tincidunt.net", Username = "R..Powers", Password = "AXI71RLB3YH" },
													new User { Id = 14, Name = "Lenore Lott", Email = "tempor.diam@PhasellusornareFusce.com", Username = "B..Roberts", Password = "MDE31BLB9NL" },
													new User { Id = 15, Name = "Gay Hanson", Email = "pretium.neque@luctusaliquet.edu", Username = "C..Mack", Password = "BIS86THL1GC" },
													new User { Id = 16, Name = "Hayes Lee", Email = "sed.dui.Fusce@quisdiamPellentesque.net", Username = "E..Atkins", Password = "NRD91BXI6LR" },
													new User { Id = 17, Name = "Stewart Castillo", Email = "elit.sed.consequat@interdumenimnon.ca", Username = "X..Cross", Password = "UEG47QJW8UQ" },
													new User { Id = 18, Name = "Kennedy House", Email = "porta.elit.a@risus.edu", Username = "N..Kelly", Password = "IXF05RPE5AO" },
													new User { Id = 19, Name = "Mark Watts", Email = "nulla.ante@Nunclaoreetlectus.com", Username = "F..Miller", Password = "VGN68EPZ7GN" },
													new User { Id = 20, Name = "Nevada Justice", Email = "tempor.diam@lectuspedeet.org", Username = "W..Herman", Password = "OJZ78MGP5QC" },
													new User { Id = 21, Name = "Caldwell Bond", Email = "velit.Aliquam@atrisus.net", Username = "W..Park", Password = "SDJ88HDJ6GR" },
													new User { Id = 22, Name = "Simon Dominguez", Email = "quis.turpis.vitae@odioNam.org", Username = "O..Tillman", Password = "WSI48TPT1AF" },
													new User { Id = 23, Name = "Ashely Kennedy", Email = "molestie.arcu.Sed@sagittislobortis.ca", Username = "L..Pennington", Password = "WLR92ODK0EH" },
													new User { Id = 24, Name = "Porter Peters", Email = "montes.nascetur.ridiculus@accumsan.net", Username = "P..Martinez", Password = "NVQ16JIQ4HB" },
													new User { Id = 25, Name = "September Melton", Email = "Mauris@non.co.uk", Username = "D..Lindsay", Password = "CQA04ZPO6ZP" },
													new User { Id = 26, Name = "Joshua Manning", Email = "faucibus@magnaNam.org", Username = "P..Obrien", Password = "DTV82OYB6BE" },
													new User { Id = 27, Name = "Hermione Moody", Email = "natoque.penatibus@magnaatortor.ca", Username = "O..Gonzalez", Password = "PAT84AHT8UV" },
													new User { Id = 28, Name = "Lunea Villarreal", Email = "vulputate.velit@metus.org", Username = "K..Pittman", Password = "DMU96NRT1KL" },
													new User { Id = 29, Name = "Sage Hale", Email = "suscipit.est.ac@euerosNam.net", Username = "E..Morrow", Password = "YLV61NJO5SF" },
													new User { Id = 30, Name = "Hermione Grimes", Email = "orci@amet.net", Username = "A..Mercer", Password = "TMX12QKB2PU" },
													new User { Id = 31, Name = "Ursa Strong", Email = "sed@turpisIncondimentum.co.uk", Username = "X..Wilkins", Password = "BVE71HSM7QB" },
													new User { Id = 32, Name = "Amber Bradford", Email = "non.hendrerit.id@vitae.edu", Username = "K..Newman", Password = "TKE41YZQ3NO" },
													new User { Id = 33, Name = "Driscoll Mayer", Email = "non.sapien.molestie@sedhendrerita.net", Username = "E..Ferguson", Password = "OUP49JYY9WF" },
													new User { Id = 34, Name = "Christian Frost", Email = "tempor.erat@lectusquismassa.ca", Username = "W..Dalton", Password = "HAT41TJT1CB" },
													new User { Id = 35, Name = "Preston Lee", Email = "sit.amet.consectetuer@iaculisaliquetdiam.edu", Username = "U..Hernandez", Password = "REP74VZT6KS" },
													new User { Id = 36, Name = "Candace Wright", Email = "massa.Quisque.porttitor@ametdapibusid.com", Username = "D..Herman", Password = "MML49BWP0CU" },
													new User { Id = 37, Name = "Jared Randall", Email = "molestie.sodales.Mauris@libero.co.uk", Username = "K..Rutledge", Password = "DQH72JSA5HU" },
													new User { Id = 38, Name = "Wallace Levine", Email = "Proin.eget@SedmolestieSed.net", Username = "B..Lopez", Password = "ITX09AKF9IM" },
													new User { Id = 39, Name = "Moses Henson", Email = "eu@magnis.org", Username = "D..Mercado", Password = "CCM48LLP9IK" },
													new User { Id = 40, Name = "Timothy Gilliam", Email = "non.sapien@pharetra.com", Username = "N..Tate", Password = "BCC53CDQ2NJ" },
													new User { Id = 41, Name = "Anika Sampson", Email = "consequat.lectus@at.co.uk", Username = "H..Neal", Password = "AWD62GLS4AC" },
													new User { Id = 42, Name = "Aaron Jacobson", Email = "lobortis.risus.In@eleifendCrassed.ca", Username = "D..Sutton", Password = "NWL80XOR7IR" },
													new User { Id = 43, Name = "Geraldine Young", Email = "Duis@nuncsit.org", Username = "Q..Sweeney", Password = "KEL68ZDM8KA" },
													new User { Id = 44, Name = "Aimee Cooke", Email = "erat.volutpat@sit.co.uk", Username = "Z..Reese", Password = "ZDV21NZQ3NL" },
													new User { Id = 45, Name = "Kirestin Thompson", Email = "est.mauris.rhoncus@Morbi.net", Username = "W..Hensley", Password = "HJH00RDW9DU" },
													new User { Id = 46, Name = "Idona Rivera", Email = "felis.eget.varius@elementumloremut.edu", Username = "S..Wilson", Password = "GGI26FSZ2DM" },
													new User { Id = 47, Name = "Leah Wiley", Email = "malesuada.fames@etmalesuada.edu", Username = "R..Sweeney", Password = "GHF06CDM4QF" },
													new User { Id = 48, Name = "Lance Fuentes", Email = "odio@rutrumlorem.net", Username = "U..Whitfield", Password = "GIL13MXK1QB" },
													new User { Id = 49, Name = "Fredericka Trujillo", Email = "penatibus.et@malesuada.ca", Username = "O..England", Password = "AYG58MYP7EV" },
													new User { Id = 50, Name = "Thor Ayala", Email = "gravida.Praesent.eu@loremipsumsodales.edu", Username = "Y..Cline", Password = "ARB56BBW4WI" },
													new User { Id = 51, Name = "Octavia Potter", Email = "Mauris@Crasloremlorem.co.uk", Username = "I..Alvarado", Password = "JKB31LGZ8BX" },
													new User { Id = 52, Name = "Dennis Holland", Email = "sed@etnetuset.co.uk", Username = "H..Dunlap", Password = "TND07NFS7EG" },
													new User { Id = 53, Name = "Cassady Cabrera", Email = "magna@Suspendisseacmetus.edu", Username = "B..Madden", Password = "PUZ31KIY5ED" },
													new User { Id = 54, Name = "Constance Shepherd", Email = "In.at.pede@Phasellus.edu", Username = "T..Finley", Password = "WJJ38MCU7PB" },
													new User { Id = 55, Name = "Helen Vargas", Email = "risus.Nulla@ultrices.net", Username = "V..Melendez", Password = "MYX66FZO5ZQ" },
													new User { Id = 56, Name = "Fulton Mccoy", Email = "malesuada.augue@cursuspurus.co.uk", Username = "A..Holder", Password = "EOB61DIJ8NO" },
													new User { Id = 57, Name = "Beverly Thompson", Email = "ante.blandit.viverra@scelerisque.org", Username = "K..Avery", Password = "MLL26LSZ4RJ" },
													new User { Id = 58, Name = "Stacy Crawford", Email = "Fusce@estNunc.com", Username = "Q..Manning", Password = "ABB87ROO8QT" },
													new User { Id = 59, Name = "Tobias Harper", Email = "Donec.luctus@felisullamcorper.org", Username = "X..Barron", Password = "HLB41EZI6HL" },
													new User { Id = 60, Name = "Walker Herrera", Email = "enim.Etiam@pedenonummy.edu", Username = "F..Schneider", Password = "ZXF95IWR8VB" },
													new User { Id = 61, Name = "Wendy Mccray", Email = "ridiculus.mus@luctus.org", Username = "E..Tanner", Password = "PVF15BRP0NW" },
													new User { Id = 62, Name = "Eve Rice", Email = "nonummy.ipsum@Etiamlaoreet.edu", Username = "X..Jacobson", Password = "HLD54FUH6BS" },
													new User { Id = 63, Name = "Moses Heath", Email = "non@ac.org", Username = "S..Hatfield", Password = "CLY72XUY1GY" },
													new User { Id = 64, Name = "Karyn Hendricks", Email = "pellentesque.massa.lobortis@velquam.net", Username = "G..Wynn", Password = "XKT92IYO5IK" },
													new User { Id = 65, Name = "Alexa Craig", Email = "senectus.et@tempusnon.net", Username = "B..Bishop", Password = "IOE90XEZ3FO" },
													new User { Id = 66, Name = "Rooney Velasquez", Email = "vitae.aliquam@orciquislectus.edu", Username = "H..Underwood", Password = "UTV92OIN2ZJ" },
													new User { Id = 67, Name = "Lara Stephens", Email = "Nullam.feugiat@faucibus.net", Username = "P..Burnett", Password = "JMC84BNO9PK" },
													new User { Id = 68, Name = "Yetta Roth", Email = "augue@nisi.org", Username = "F..Koch", Password = "USY75HIF0LR" },
													new User { Id = 69, Name = "Astra Roman", Email = "luctus.vulputate@ligula.com", Username = "F..Young", Password = "NGF63JPF6CM" },
													new User { Id = 70, Name = "Dean Burns", Email = "egestas.blandit.Nam@commodoauctor.edu", Username = "E..Carpenter", Password = "OZA21QJU1QC" },
													new User { Id = 71, Name = "Ryder Greene", Email = "non.arcu@Etiam.net", Username = "B..Pennington", Password = "ZMB26APO7OX" },
													new User { Id = 72, Name = "Tate Sheppard", Email = "tellus.Nunc@ipsumnuncid.net", Username = "I..Patton", Password = "PGL53NBG5OS" },
													new User { Id = 73, Name = "Oliver Cotton", Email = "justo.nec.ante@Duisvolutpat.org", Username = "A..Grant", Password = "XXD25LTQ6NY" },
													new User { Id = 74, Name = "Charissa Conrad", Email = "pharetra@nonloremvitae.edu", Username = "R..Romero", Password = "ETG18EGL2AE" },
													new User { Id = 75, Name = "Mira Livingston", Email = "nibh@egetmetus.edu", Username = "X..Ferguson", Password = "UVL35GOU3RM" },
													new User { Id = 76, Name = "Ora Beach", Email = "nascetur.ridiculus.mus@malesuadafamesac.org", Username = "B..Fields", Password = "NFH77BMK1IO" },
													new User { Id = 77, Name = "Olympia Sharpe", Email = "metus@Vivamusmolestie.org", Username = "C..Britt", Password = "MOF56BCG9ZQ" },
													new User { Id = 78, Name = "Cheyenne Bartlett", Email = "Proin@diamluctus.co.uk", Username = "R..Stanton", Password = "RJI86TFA9WV" },
													new User { Id = 79, Name = "Amena Guy", Email = "eu.accumsan@faucibusutnulla.ca", Username = "C..Gibbs", Password = "EHN49KEZ3KT" },
													new User { Id = 80, Name = "Kiona Kramer", Email = "Nullam.velit.dui@Morbinon.org", Username = "M..Snyder", Password = "XXO37JTR8EA" },
													new User { Id = 81, Name = "Ralph Koch", Email = "Lorem@liberonec.org", Username = "F..Ford", Password = "MWJ85DHO8PH" },
													new User { Id = 82, Name = "Willow Parks", Email = "pellentesque.eget.dictum@consectetueradipiscing.edu", Username = "N..Bauer", Password = "LOI33MNJ7RC" },
													new User { Id = 83, Name = "Darryl Collins", Email = "nec@ad.co.uk", Username = "U..Grant", Password = "UWN48CCL5EP" },
													new User { Id = 84, Name = "Oliver Owen", Email = "turpis.Aliquam@montesnasceturridiculus.net", Username = "Y..Winters", Password = "YKY71VAI3IY" },
													new User { Id = 85, Name = "Honorato Bartlett", Email = "blandit@lorem.edu", Username = "Q..Carson", Password = "MEA22TPZ1GO" },
													new User { Id = 86, Name = "Hasad Salas", Email = "fermentum@malesuadafamesac.ca", Username = "W..Burgess", Password = "QOB01ZSV3KA" },
													new User { Id = 87, Name = "Slade Day", Email = "nec.urna.suscipit@dictum.ca", Username = "N..Hancock", Password = "ZEC91UQM4VC" },
													new User { Id = 88, Name = "Plato Blanchard", Email = "Cum.sociis@Mauris.edu", Username = "A..Alvarado", Password = "WQA70OXC3KP" },
													new User { Id = 89, Name = "Adria Dickerson", Email = "molestie.sodales@sedconsequat.ca", Username = "C..Hendrix", Password = "WZB56XHL9PC" },
													new User { Id = 90, Name = "Megan Wilcox", Email = "turpis.vitae.purus@loremtristiquealiquet.com", Username = "W..Gonzales", Password = "IEI12YFN2FG" },
													new User { Id = 91, Name = "Brielle Kelly", Email = "euismod@afelis.ca", Username = "L..Hyde", Password = "MPK69MFU4EL" },
													new User { Id = 92, Name = "Hillary Le", Email = "orci@imperdietdictum.ca", Username = "B..Boone", Password = "MAC71DZY8FI" },
													new User { Id = 93, Name = "Medge Klein", Email = "fringilla@apurus.ca", Username = "U..Ray", Password = "PWJ37HXI7GM" },
													new User { Id = 94, Name = "Driscoll Chandler", Email = "justo@et.org", Username = "B..Carney", Password = "JXK33JHI0UE" },
													new User { Id = 95, Name = "Quentin Marks", Email = "purus@vitaevelit.co.uk", Username = "T..Sloan", Password = "DEM62OHM8ZU" },
													new User { Id = 96, Name = "Benedict Guerrero", Email = "eu.lacus.Quisque@penatibuset.edu", Username = "P..Mullen", Password = "ZAG98KGW1HK" },
													new User { Id = 97, Name = "Harriet Mcdonald", Email = "magna.Phasellus.dolor@sitamet.ca", Username = "Y..Mercer", Password = "INH43HAA4CE" },
													new User { Id = 98, Name = "Craig Spence", Email = "Aenean.eget.magna@malesuada.com", Username = "C..Cline", Password = "XBN62ARA4TC" },
													new User { Id = 99, Name = "Kirby Goodman", Email = "dignissim@elementumategestas.net", Username = "O..Nunez", Password = "ZIB97TAR2CB" },
													new User { Id = 100, Name = "Clementine Greer", Email = "a@aenimSuspendisse.net", Username = "G..Clay", Password = "OJR43CQY1KF" },
													new User { Id = 101, Name = "Sergio Valadão Junior", Email = "a@aenimSuspendisse.net", Username = "S..Junior", Password = "12345678" },
													new User { Id = 101, Name = "Sergio Valadão", Email = "s@aenimSuspendisse.net", Username = "S..Valadao", Password = "12345678" }
												};


    }
}
