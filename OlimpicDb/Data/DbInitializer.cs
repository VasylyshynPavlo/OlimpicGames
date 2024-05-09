using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OlimpicDb.Entity;

namespace OlimpicDb.Data
{
    public class DbInitializer
    {
        public static void SetDefaultdata(ModelBuilder modelBuilder)
        {
            #region Country
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new Country { Id =1, Name = "Afghanistan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Flag_of_Afghanistan_%282013%E2%80%932021%29.svg/320px-Flag_of_Afghanistan_%282013%E2%80%932021%29.svg.png"},
                new Country { Id =2, Name = "Albania", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/320px-Flag_of_Albania.svg.png"},
                new Country { Id =3, Name = "Algeria", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Algeria.svg/320px-Flag_of_Algeria.svg.png"},
                new Country { Id =4, Name = "American Samoa", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Flag_of_American_Samoa.svg/320px-Flag_of_American_Samoa.svg.png"},
                new Country { Id =5, Name = "Andorra", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Andorra.svg/320px-Flag_of_Andorra.svg.png"},
                new Country { Id =6, Name = "Angola", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Flag_of_Angola.svg/320px-Flag_of_Angola.svg.png"},
                new Country { Id =7, Name = "Antigua and Barbuda", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Flag_of_Antigua_and_Barbuda.svg/320px-Flag_of_Antigua_and_Barbuda.svg.png"},
                new Country { Id =8, Name = "Argentina", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Flag_of_Argentina.svg/320px-Flag_of_Argentina.svg.png"},
                new Country { Id =9, Name = "Armenia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Flag_of_Armenia.svg/320px-Flag_of_Armenia.svg.png"},
                new Country { Id =10, Name = "Aruba", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Flag_of_Aruba.svg/320px-Flag_of_Aruba.svg.png"},
                new Country { Id =11, Name = "Australia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b9/Flag_of_Australia.svg/320px-Flag_of_Australia.svg.png"},
                new Country { Id =12, Name = "Austria", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/320px-Flag_of_Austria.svg.png"},
                new Country { Id =13, Name = "Azerbaijan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Azerbaijan.svg/320px-Flag_of_Azerbaijan.svg.png"},
                new Country { Id =14, Name = "Bahamas", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Flag_of_the_Bahamas.svg/320px-Flag_of_the_Bahamas.svg.png"},
                new Country { Id =15, Name = "Bahrain", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Bahrain.svg/320px-Flag_of_Bahrain.svg.png"},
                new Country { Id =16, Name = "Bangladesh", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Flag_of_Bangladesh.svg/320px-Flag_of_Bangladesh.svg.png"},
                new Country { Id =17, Name = "Barbados", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Flag_of_Barbados.svg/320px-Flag_of_Barbados.svg.png"},
                new Country { Id =18, Name = "Belarus", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Flag_of_Belarus.svg/320px-Flag_of_Belarus.svg.png"},
                new Country { Id =19, Name = "Belgium", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Belgium_%28civil%29.svg/320px-Flag_of_Belgium_%28civil%29.svg.png"},
                new Country { Id =20, Name = "Belize", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Flag_of_Belize.svg/320px-Flag_of_Belize.svg.png"},
                new Country { Id =21, Name = "Benin", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_Benin.svg/320px-Flag_of_Benin.svg.png"},
                new Country { Id =22, Name = "Bermuda", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bermuda.svg/320px-Flag_of_Bermuda.svg.png"},
                new Country { Id =23, Name = "Bhutan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Flag_of_Bhutan.svg/320px-Flag_of_Bhutan.svg.png"},
                new Country { Id =24, Name = "Bolivia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Bolivia.svg/320px-Flag_of_Bolivia.svg.png"},
                new Country { Id =25, Name = "Bosnia and Herzegovina", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bosnia_and_Herzegovina.svg/320px-Flag_of_Bosnia_and_Herzegovina.svg.png"},
                new Country { Id =26, Name = "Botswana", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_Botswana.svg/320px-Flag_of_Botswana.svg.png"},
                new Country { Id =27, Name = "Brazil", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/320px-Flag_of_Brazil.svg.png"},
                new Country { Id =28, Name = "British Virgin Islands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Flag_of_the_British_Virgin_Islands.svg/320px-Flag_of_the_British_Virgin_Islands.svg.png"},
                new Country { Id =29, Name = "Brunei", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Brunei.svg/320px-Flag_of_Brunei.svg.png"},
                new Country { Id =30, Name = "Bulgaria", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Bulgaria.svg/320px-Flag_of_Bulgaria.svg.png"},
                new Country { Id =31, Name = "Burkina Faso", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Burkina_Faso.svg/320px-Flag_of_Burkina_Faso.svg.png"},
                new Country { Id =32, Name = "Burundi", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Flag_of_Burundi.svg/320px-Flag_of_Burundi.svg.png"},
                new Country { Id =33, Name = "Cambodia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_Cambodia.svg/320px-Flag_of_Cambodia.svg.png"},
                new Country { Id =34, Name = "Cameroon", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Flag_of_Cameroon.svg/320px-Flag_of_Cameroon.svg.png"},
                new Country { Id =35, Name = "Canada", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Canada_%28Pantone%29.svg/320px-Flag_of_Canada_%28Pantone%29.svg.png"},
                new Country { Id =36, Name = "Cape Verde", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Cape_Verde.svg/320px-Flag_of_Cape_Verde.svg.png"},
                new Country { Id =37, Name = "Cayman Islands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Flag_of_the_Cayman_Islands_%28pre-1999%29.svg/320px-Flag_of_the_Cayman_Islands_%28pre-1999%29.svg.png"},
                new Country { Id =38, Name = "Central African Republic", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Central_African_Republic.svg/320px-Flag_of_the_Central_African_Republic.svg.png"},
                new Country { Id =39, Name = "Chad", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Flag_of_Chad.svg/320px-Flag_of_Chad.svg.png"},
                new Country { Id =40, Name = "Chile", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Flag_of_Chile.svg/320px-Flag_of_Chile.svg.png"},
                new Country { Id =41, Name = "China", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/320px-Flag_of_the_People%27s_Republic_of_China.svg.png"},
                new Country { Id =42, Name = "Chinese Taipei", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Flag_of_Chinese_Taipei_for_Olympic_games.svg/320px-Flag_of_Chinese_Taipei_for_Olympic_games.svg.png"},
                new Country { Id =43, Name = "Colombia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Colombia.svg/320px-Flag_of_Colombia.svg.png"},
                new Country { Id =44, Name = "Comoros", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Flag_of_the_Comoros.svg/320px-Flag_of_the_Comoros.svg.png"},
                new Country { Id =45, Name = "Cook Islands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Flag_of_the_Cook_Islands.svg/320px-Flag_of_the_Cook_Islands.svg.png"},
                new Country { Id =46, Name = "Costa Rica", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Flag_of_Costa_Rica.svg/320px-Flag_of_Costa_Rica.svg.png"},
                new Country { Id =47, Name = "Croatia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/320px-Flag_of_Croatia.svg.png"},
                new Country { Id =48, Name = "Cuba", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Flag_of_Cuba.svg/320px-Flag_of_Cuba.svg.png"},
                new Country { Id =49, Name = "Cyprus", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Cyprus.svg/320px-Flag_of_Cyprus.svg.png"},
                new Country { Id =50, Name = "Czech Republic", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_Czech_Republic.svg/320px-Flag_of_the_Czech_Republic.svg.png"},
                new Country { Id =51, Name = "Democratic Republic of the Congo", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Democratic_Republic_of_the_Congo.svg/320px-Flag_of_the_Democratic_Republic_of_the_Congo.svg.png"},
                new Country { Id =52, Name = "Denmark", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Denmark.svg/320px-Flag_of_Denmark.svg.png"},
                new Country { Id =53, Name = "Djibouti", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Flag_of_Djibouti.svg/320px-Flag_of_Djibouti.svg.png"},
                new Country { Id =54, Name = "Dominica", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Flag_of_Dominica.svg/320px-Flag_of_Dominica.svg.png"},
                new Country { Id =55, Name = "Dominican Republic", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_the_Dominican_Republic.svg/320px-Flag_of_the_Dominican_Republic.svg.png"},
                new Country { Id =56, Name = "East Timor", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Flag_of_East_Timor.svg/320px-Flag_of_East_Timor.svg.png"},
                new Country { Id =57, Name = "Ecuador", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Flag_of_Ecuador.svg/320px-Flag_of_Ecuador.svg.png"},
                new Country { Id =58, Name = "Egypt", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Egypt.svg/320px-Flag_of_Egypt.svg.png"},
                new Country { Id =59, Name = "El Salvador", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Flag_of_El_Salvador.svg/320px-Flag_of_El_Salvador.svg.png"},
                new Country { Id =60, Name = "Equatorial Guinea", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Equatorial_Guinea.svg/320px-Flag_of_Equatorial_Guinea.svg.png"},
                new Country { Id =61, Name = "Eritrea", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Flag_of_Eritrea.svg/320px-Flag_of_Eritrea.svg.png"},
                new Country { Id =62, Name = "Estonia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flag_of_Estonia.svg/320px-Flag_of_Estonia.svg.png"},
                new Country { Id =63, Name = "Eswatini", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Flag_of_Eswatini.svg/320px-Flag_of_Eswatini.svg.png"},
                new Country { Id =64, Name = "Ethiopia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Flag_of_Ethiopia.svg/320px-Flag_of_Ethiopia.svg.png"},
                new Country { Id =65, Name = "Federated States of Micronesia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Flag_of_the_Federated_States_of_Micronesia.svg/320px-Flag_of_the_Federated_States_of_Micronesia.svg.png"},
                new Country { Id =66, Name = "Fiji", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Fiji.svg/320px-Flag_of_Fiji.svg.png"},
                new Country { Id =67, Name = "Finland", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Finland.svg/320px-Flag_of_Finland.svg.png"},
                new Country { Id =68, Name = "France", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/320px-Flag_of_France.svg.png"},
                new Country { Id =69, Name = "Gabon", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Flag_of_Gabon.svg/320px-Flag_of_Gabon.svg.png"},
                new Country { Id =70, Name = "Georgia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Georgia.svg/320px-Flag_of_Georgia.svg.png"},
                new Country { Id =71, Name = "Germany", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/320px-Flag_of_Germany.svg.png"},
                new Country { Id =72, Name = "Ghana", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Ghana.svg/320px-Flag_of_Ghana.svg.png"},
                new Country { Id =73, Name = "Great Britain", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/320px-Flag_of_the_United_Kingdom.svg.png"},
                new Country { Id =74, Name = "Greece", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Greece.svg/320px-Flag_of_Greece.svg.png"},
                new Country { Id =75, Name = "Grenada", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Grenada.svg/320px-Flag_of_Grenada.svg.png"},
                new Country { Id =76, Name = "Guam", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Flag_of_Guam.svg/320px-Flag_of_Guam.svg.png"},
                new Country { Id =77, Name = "Guatemala", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Flag_of_Guatemala.svg/320px-Flag_of_Guatemala.svg.png"},
                new Country { Id =78, Name = "Guinea", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Flag_of_Guinea.svg/320px-Flag_of_Guinea.svg.png"},
                new Country { Id =79, Name = "Guinea-Bissau", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_Guinea-Bissau.svg/320px-Flag_of_Guinea-Bissau.svg.png"},
                new Country { Id =80, Name = "Guyana", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Flag_of_Guyana.svg/320px-Flag_of_Guyana.svg.png"},
                new Country { Id =81, Name = "Haiti", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Haiti.svg/320px-Flag_of_Haiti.svg.png"},
                new Country { Id =82, Name = "Honduras", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Flag_of_Honduras_%281949%E2%80%932022%29.svg/320px-Flag_of_Honduras_%281949%E2%80%932022%29.svg.png"},
                new Country { Id =83, Name = "Hong Kong", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Flag_of_Hong_Kong.svg/320px-Flag_of_Hong_Kong.svg.png"},
                new Country { Id =84, Name = "Hungary", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Flag_of_Hungary.svg/320px-Flag_of_Hungary.svg.png"},
                new Country { Id =85, Name = "Iceland", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Iceland.svg/320px-Flag_of_Iceland.svg.png"},
                new Country { Id =86, Name = "India", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Flag_of_India.svg/320px-Flag_of_India.svg.png"},
                new Country { Id =87, Name = "Indonesia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Indonesia.svg/320px-Flag_of_Indonesia.svg.png"},
                new Country { Id =88, Name = "Iran", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Flag_of_Iran.svg/320px-Flag_of_Iran.svg.png"},
                new Country { Id =89, Name = "Iraq", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Flag_of_Iraq.svg/320px-Flag_of_Iraq.svg.png"},
                new Country { Id =90, Name = "Ireland", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Flag_of_Ireland.svg/320px-Flag_of_Ireland.svg.png"},
                new Country { Id =91, Name = "Israel", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/320px-Flag_of_Israel.svg.png"},
                new Country { Id =92, Name = "Italy", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/320px-Flag_of_Italy.svg.png"},
                new Country { Id =93, Name = "Ivory Coast", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_C%C3%B4te_d%27Ivoire.svg/320px-Flag_of_C%C3%B4te_d%27Ivoire.svg.png"},
                new Country { Id =94, Name = "Jamaica", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_Jamaica.svg/320px-Flag_of_Jamaica.svg.png"},
                new Country { Id =95, Name = "Japan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/320px-Flag_of_Japan.svg.png"},
                new Country { Id =96, Name = "Jordan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c0/Flag_of_Jordan.svg/320px-Flag_of_Jordan.svg.png"},
                new Country { Id =97, Name = "Kazakhstan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Flag_of_Kazakhstan.svg/320px-Flag_of_Kazakhstan.svg.png"},
                new Country { Id =98, Name = "Kenya", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Kenya.svg/320px-Flag_of_Kenya.svg.png"},
                new Country { Id =99, Name = "Kiribati", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Flag_of_Kiribati.svg/320px-Flag_of_Kiribati.svg.png"},
                new Country { Id =100, Name = "Kosovo", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Flag_of_Kosovo.svg/320px-Flag_of_Kosovo.svg.png"},
                new Country { Id =101, Name = "Kuwait", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Flag_of_Kuwait.svg/320px-Flag_of_Kuwait.svg.png"},
                new Country { Id =102, Name = "Kyrgyzstan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Flag_of_Kyrgyzstan_%281992%E2%80%932023%29.svg/320px-Flag_of_Kyrgyzstan_%281992%E2%80%932023%29.svg.png"},
                new Country { Id =103, Name = "Laos", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Laos.svg/320px-Flag_of_Laos.svg.png"},
                new Country { Id =104, Name = "Latvia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Latvia.svg/320px-Flag_of_Latvia.svg.png"},
                new Country { Id =105, Name = "Lebanon", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Flag_of_Lebanon.svg/320px-Flag_of_Lebanon.svg.png"},
                new Country { Id =106, Name = "Lesotho", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Flag_of_Lesotho.svg/320px-Flag_of_Lesotho.svg.png"},
                new Country { Id =107, Name = "Liberia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Flag_of_Liberia.svg/320px-Flag_of_Liberia.svg.png"},
                new Country { Id =108, Name = "Libya", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Flag_of_Libya.svg/320px-Flag_of_Libya.svg.png"},
                new Country { Id =109, Name = "Liechtenstein", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Flag_of_Liechtenstein.svg/320px-Flag_of_Liechtenstein.svg.png"},
                new Country { Id =110, Name = "Lithuania", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Lithuania.svg/320px-Flag_of_Lithuania.svg.png"},
                new Country { Id =111, Name = "Luxembourg", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Flag_of_Luxembourg.svg/320px-Flag_of_Luxembourg.svg.png"},
                new Country { Id =112, Name = "Madagascar", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Madagascar.svg/320px-Flag_of_Madagascar.svg.png"},
                new Country { Id =113, Name = "Malawi", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Flag_of_Malawi.svg/320px-Flag_of_Malawi.svg.png"},
                new Country { Id =114, Name = "Malaysia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Flag_of_Malaysia.svg/320px-Flag_of_Malaysia.svg.png"},
                new Country { Id =115, Name = "Maldives", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Maldives.svg/320px-Flag_of_Maldives.svg.png"},
                new Country { Id =116, Name = "Mali", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Mali.svg/320px-Flag_of_Mali.svg.png"},
                new Country { Id =117, Name = "Malta", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Malta.svg/320px-Flag_of_Malta.svg.png"},
                new Country { Id =118, Name = "Marshall Islands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Flag_of_the_Marshall_Islands.svg/320px-Flag_of_the_Marshall_Islands.svg.png"},
                new Country { Id =119, Name = "Mauritania", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Flag_of_Mauritania.svg/320px-Flag_of_Mauritania.svg.png"},
                new Country { Id =120, Name = "Mauritius", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Mauritius.svg/320px-Flag_of_Mauritius.svg.png"},
                new Country { Id =121, Name = "Mexico", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Mexico.svg/320px-Flag_of_Mexico.svg.png"},
                new Country { Id =122, Name = "Moldova", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Moldova.svg/320px-Flag_of_Moldova.svg.png"},
                new Country { Id =123, Name = "Monaco", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Flag_of_Monaco.svg/320px-Flag_of_Monaco.svg.png"},
                new Country { Id =124, Name = "Mongolia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Flag_of_Mongolia.svg/320px-Flag_of_Mongolia.svg.png"},
                new Country { Id =125, Name = "Montenegro", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Flag_of_Montenegro.svg/320px-Flag_of_Montenegro.svg.png"},
                new Country { Id =126, Name = "Morocco", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Morocco.svg/320px-Flag_of_Morocco.svg.png"},
                new Country { Id =127, Name = "Mozambique", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Flag_of_Mozambique.svg/320px-Flag_of_Mozambique.svg.png"},
                new Country { Id =128, Name = "Myanmar", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Flag_of_Myanmar.svg/320px-Flag_of_Myanmar.svg.png"},
                new Country { Id =129, Name = "Namibia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Flag_of_Namibia.svg/320px-Flag_of_Namibia.svg.png"},
                new Country { Id =130, Name = "Nauru", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Flag_of_Nauru.svg/320px-Flag_of_Nauru.svg.png"},
                new Country { Id =131, Name = "Nepal", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Flag_of_Nepal.svg/320px-Flag_of_Nepal.svg.png"},
                new Country { Id =132, Name = "Netherlands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/320px-Flag_of_the_Netherlands.svg.png"},
                new Country { Id =133, Name = "New Zealand", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Flag_of_New_Zealand.svg/320px-Flag_of_New_Zealand.svg.png"},
                new Country { Id =134, Name = "Nicaragua", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Nicaragua.svg/320px-Flag_of_Nicaragua.svg.png"},
                new Country { Id =135, Name = "Niger", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Flag_of_Niger.svg/320px-Flag_of_Niger.svg.png"},
                new Country { Id =136, Name = "Nigeria", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_Nigeria.svg/320px-Flag_of_Nigeria.svg.png"},
                new Country { Id =137, Name = "North Macedonia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_North_Macedonia.svg/320px-Flag_of_North_Macedonia.svg.png"},
                new Country { Id =138, Name = "Norway", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Norway.svg/320px-Flag_of_Norway.svg.png"},
                new Country { Id =139, Name = "Oman", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Oman.svg/320px-Flag_of_Oman.svg.png"},
                new Country { Id =140, Name = "Pakistan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Flag_of_Pakistan.svg/320px-Flag_of_Pakistan.svg.png"},
                new Country { Id =141, Name = "Palau", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Palau.svg/320px-Flag_of_Palau.svg.png"},
                new Country { Id =142, Name = "Palestine", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Flag_of_Palestine.svg/320px-Flag_of_Palestine.svg.png"},
                new Country { Id =143, Name = "Panama", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Flag_of_Panama.svg/320px-Flag_of_Panama.svg.png"},
                new Country { Id =144, Name = "Papua New Guinea", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Flag_of_Papua_New_Guinea.svg/320px-Flag_of_Papua_New_Guinea.svg.png"},
                new Country { Id =145, Name = "Paraguay", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Paraguay.svg/320px-Flag_of_Paraguay.svg.png"},
                new Country { Id =146, Name = "Peru", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Peru.svg/320px-Flag_of_Peru.svg.png"},
                new Country { Id =147, Name = "Philippines", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Flag_of_the_Philippines.svg/320px-Flag_of_the_Philippines.svg.png"},
                new Country { Id =148, Name = "Poland", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Flag_of_Poland.svg/320px-Flag_of_Poland.svg.png"},
                new Country { Id =149, Name = "Portugal", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Portugal.svg/320px-Flag_of_Portugal.svg.png"},
                new Country { Id =150, Name = "Puerto Rico", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Flag_of_Puerto_Rico.svg/320px-Flag_of_Puerto_Rico.svg.png"},
                new Country { Id =151, Name = "Qatar", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Qatar.svg/320px-Flag_of_Qatar.svg.png"},
                new Country { Id =152, Name = "Refugee Olympic Team", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Olympic_flag.svg/320px-Olympic_flag.svg.png"},
                new Country { Id =153, Name = "Republic of the Congo", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_the_Republic_of_the_Congo.svg/320px-Flag_of_the_Republic_of_the_Congo.svg.png"},
                new Country { Id =154, Name = "ROC", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Russian_Olympic_Committee_flag.png/320px-Russian_Olympic_Committee_flag.png"},
                new Country { Id =155, Name = "Romania", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/320px-Flag_of_Romania.svg.png"},
                new Country { Id =156, Name = "Rwanda", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Rwanda.svg/320px-Flag_of_Rwanda.svg.png"},
                new Country { Id =157, Name = "Saint Kitts and Nevis", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Saint_Kitts_and_Nevis.svg/320px-Flag_of_Saint_Kitts_and_Nevis.svg.png"},
                new Country { Id =158, Name = "Saint Lucia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Saint_Lucia.svg/320px-Flag_of_Saint_Lucia.svg.png"},
                new Country { Id =159, Name = "Saint Vincent and the Grenadines", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Flag_of_Saint_Vincent_and_the_Grenadines.svg/320px-Flag_of_Saint_Vincent_and_the_Grenadines.svg.png"},
                new Country { Id =160, Name = "Samoa", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Samoa.svg/320px-Flag_of_Samoa.svg.png"},
                new Country { Id =161, Name = "San Marino", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Flag_of_San_Marino.svg/320px-Flag_of_San_Marino.svg.png"},
                new Country { Id =162, Name = "São Tomé and Príncipe", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe.svg/320px-Flag_of_S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe.svg.png"},
                new Country { Id =163, Name = "Saudi Arabia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Flag_of_Saudi_Arabia.svg/320px-Flag_of_Saudi_Arabia.svg.png"},
                new Country { Id =164, Name = "Senegal", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Flag_of_Senegal.svg/320px-Flag_of_Senegal.svg.png"},
                new Country { Id =165, Name = "Serbia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/320px-Flag_of_Israel.svg.png"},
                new Country { Id =166, Name = "Seychelles", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Seychelles.svg/320px-Flag_of_Seychelles.svg.png"},
                new Country { Id =167, Name = "Sierra Leone", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Sierra_Leone.svg/320px-Flag_of_Sierra_Leone.svg.png"},
                new Country { Id =168, Name = "Singapore", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Singapore.svg/320px-Flag_of_Singapore.svg.png"},
                new Country { Id =169, Name = "Slovakia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Flag_of_Slovakia.svg/320px-Flag_of_Slovakia.svg.png"},
                new Country { Id =170, Name = "Slovenia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Flag_of_Slovenia.svg/320px-Flag_of_Slovenia.svg.png"},
                new Country { Id =171, Name = "Solomon Islands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Flag_of_the_Solomon_Islands.svg/320px-Flag_of_the_Solomon_Islands.svg.png"},
                new Country { Id =172, Name = "Somalia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Flag_of_Somalia.svg/320px-Flag_of_Somalia.svg.png"},
                new Country { Id =173, Name = "South Africa", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Flag_of_South_Africa.svg/320px-Flag_of_South_Africa.svg.png"},
                new Country { Id =174, Name = "South Korea", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Flag_of_South_Korea.svg/320px-Flag_of_South_Korea.svg.png"},
                new Country { Id =175, Name = "South Sudan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/Flag_of_South_Sudan.svg/320px-Flag_of_South_Sudan.svg.png"},
                new Country { Id =176, Name = "Spain", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/320px-Flag_of_Spain.svg.png"},
                new Country { Id =177, Name = "Sri Lanka", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Sri_Lanka.svg/320px-Flag_of_Sri_Lanka.svg.png"},
                new Country { Id =178, Name = "Sudan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_Sudan.svg/320px-Flag_of_Sudan.svg.png"},
                new Country { Id =179, Name = "Suriname", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Flag_of_Suriname.svg/320px-Flag_of_Suriname.svg.png"},
                new Country { Id =180, Name = "Sweden", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/Flag_of_Sweden.svg/320px-Flag_of_Sweden.svg.png"},
                new Country { Id =181, Name = "Switzerland", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/320px-Flag_of_Switzerland.svg.png"},
                new Country { Id =182, Name = "Syria", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Flag_of_Syria.svg/320px-Flag_of_Syria.svg.png"},
                new Country { Id =183, Name = "Tajikistan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Flag_of_Tajikistan.svg/320px-Flag_of_Tajikistan.svg.png"},
                new Country { Id =184, Name = "Tanzania", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Tanzania.svg/320px-Flag_of_Tanzania.svg.png"},
                new Country { Id =185, Name = "Thailand", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Flag_of_Thailand.svg/320px-Flag_of_Thailand.svg.png"},
                new Country { Id =186, Name = "The Gambia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_The_Gambia.svg/320px-Flag_of_The_Gambia.svg.png"},
                new Country { Id =187, Name = "Togo", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Flag_of_Togo.svg/320px-Flag_of_Togo.svg.png"},
                new Country { Id =188, Name = "Tonga", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Tonga.svg/320px-Flag_of_Tonga.svg.png"},
                new Country { Id =189, Name = "Trinidad and Tobago", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Flag_of_Trinidad_and_Tobago.svg/320px-Flag_of_Trinidad_and_Tobago.svg.png"},
                new Country { Id =190, Name = "Tunisia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Tunisia.svg/320px-Flag_of_Tunisia.svg.png"},
                new Country { Id =191, Name = "Turkey", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Flag_of_Turkey.svg/320px-Flag_of_Turkey.svg.png"},
                new Country { Id =192, Name = "Turkmenistan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Turkmenistan.svg/320px-Flag_of_Turkmenistan.svg.png"},
                new Country { Id =193, Name = "Tuvalu", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Tuvalu.svg/320px-Flag_of_Tuvalu.svg.png"},
                new Country { Id =194, Name = "Uganda", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Flag_of_Uganda.svg/320px-Flag_of_Uganda.svg.png"},
                new Country { Id =195, Name = "Ukraine", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Ukraine.svg/320px-Flag_of_Ukraine.svg.png"},
                new Country { Id =196, Name = "United Arab Emirates", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_United_Arab_Emirates.svg/320px-Flag_of_the_United_Arab_Emirates.svg.png"},
                new Country { Id =197, Name = "United States", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/320px-Flag_of_the_United_States.svg.png"},
                new Country { Id =198, Name = "Uruguay", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Uruguay.svg/320px-Flag_of_Uruguay.svg.png"},
                new Country { Id =199, Name = "Uzbekistan", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Uzbekistan.svg/320px-Flag_of_Uzbekistan.svg.png"},
                new Country { Id =200, Name = "Vanuatu", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Vanuatu.svg/320px-Flag_of_Vanuatu.svg.png"},
                new Country { Id =201, Name = "Venezuela", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/Flag_of_Venezuela_%28state%29.svg/320px-Flag_of_Venezuela_%28state%29.svg.png"},
                new Country { Id =202, Name = "Vietnam", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Vietnam.svg/320px-Flag_of_Vietnam.svg.png"},
                new Country { Id =203, Name = "Virgin Islands", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Flag_of_the_United_States_Virgin_Islands.svg/320px-Flag_of_the_United_States_Virgin_Islands.svg.png"},
                new Country { Id =204, Name = "Yemen", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Flag_of_Yemen.svg/320px-Flag_of_Yemen.svg.png"},
                new Country { Id =205, Name = "Zambia", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Flag_of_Zambia.svg/320px-Flag_of_Zambia.svg.png"},
                new Country { Id =206, Name = "Zimbabwe", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Flag_of_Zimbabwe.svg/320px-Flag_of_Zimbabwe.svg.png"},
                new Country { Id =207, Name = "Refugee Olympic Team", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Olympic_flag.svg/1200px-Olympic_flag.svg.png"},
                new Country { Id =208, Name = "Côte d'Ivoire", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_C%C3%B4te_d%27Ivoire.svg/640px-Flag_of_C%C3%B4te_d%27Ivoire.svg.png"},
                new Country { Id =209, Name = "Congo", CountryFlagLink = "https://upload.wikimedia.org/wikipedia/commons/9/92/Flag_of_the_Republic_of_the_Congo.svg"},
            });
            #endregion

            #region Player
            try
            {
                List<Player> tmp = new();
                string json = File.ReadAllText("Players.json");
                List<Player> players = JsonConvert.DeserializeObject<List<Player>>(json);
                if (players != null || players.Count > 0)
                {
                    foreach (Player player in players)
                    {
                        tmp.Add(player);
                    }
                }
                modelBuilder.Entity<Player>().HasData(new List<Player>(tmp));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Place
            modelBuilder.Entity<Place>().HasData(new Place[]
            {
                new Place {Id = 1, City = "Tokio", CountryId = 95, Date = "23 July 2021"},
            });
            #endregion

            #region Sport
            modelBuilder.Entity<Sport>().HasData(new Sport[]
            {
                new Sport {Id = 1, Name = "NONE", Description = "Sport not specified"},
                new Sport {Id = 2, Name = "Swimming", Description = "At the Olympic Games, swimming events are held in a pool measuring 50 metres in length. The four strokes of Olympic swimming events—for both individual and relay races—are breaststroke, butterfly, backstroke and front crawl; the front crawl is predominantly used in freestyle races, and as such the term freestyle is often used as a synonym for front crawl. A fifth race, the mixed medley, involves all four strokes, with swimmers switching between them. The distances also vary, with different skills needed for a 50m race to a 1500m event. Explosivity, endurance, strength and technique are all essential qualities for swimmers."},
                new Sport {Id = 3, Name = "Taekwondo", Description = "The aim of taekwondo is for an athlete to kick and punch their opponent while avoiding being struck themselves. The trademark of this martial art is its combination of kicking and punching movements in quick succession. Matches are fought on an octagonal mat for three rounds of two minutes each. Points are awarded according to the degree of difficulty of techniques used; for example, a kick to the head scores higher than punches and kicks to the trunk. Spinning kicks are also rewarded with extra points. Penalties may be given to athletes for various faults."},
                new Sport {Id = 4, Name = "Athletics", Description = "Modern athletics is composed of various running, jumping, throwing, walking, and combined events. Due to its many categories and disciplines, athletics involves the most participants in a single sport at the Olympic Games. The track programme includes sprints, middle-distance and long-distance events as well as hurdles, steeplechase races, and relays for men and women. These events take place on the 400m oval track in the Olympic stadium (made up of two straights and two curved bends). Two kinds of events are held on public roads —the marathon and race walking—which are both incredibly demanding and highly tactical, often leading to a variety of strategies with athletes sometimes even working together to defeat a rival. Spectators line the route to watch and cheer the athletes on. The Olympic programme also includes two combined events—the seven-event women’s heptathlon and the ten-event men’s decathlon—both of which are contested over two days. Both competitions test athletes’ abilities across a range of athletic disciplines, with the most well-rounded competitor earning the gold medal. The disciplines are contested on, within, and around the track in the Olympic stadium, in the jumping area (high jump and pole vault), the jumping pit (long jump and triple jump), the throwing circle (shot put, discus and hammer throw), and the javelin runway. Athletes compete one after another, and the event includes a qualifying stage during which the best athletes secure their place in the final."},
                new Sport {Id = 5, Name = "Shooting", Description = "There are three Olympic shooting disciplines: rifle, pistol and shotgun. Rifle and pistol events take place on shooting ranges, where athletes aim at targets at distances of 10m, 25m and 50m. There are also three positions: kneeling (where the athlete goes down on one knee and rests the elbow on the other knee), prone and standing. Some events include all positions. To hit the targets as accurately and as close to the centre (the bullseye) as possible, marksmen use relaxation techniques to lower their heartbeat. Shotgun events are different in principle, as they take place outdoors. Marksmen shoot at flying targets fired from different angles and directions. This sport demands a great deal of concentration, decision making and sharp reflexes."},
                new Sport {Id = 6, Name = "Weightlifting", Description = "The Olympic weightlifting programme has greatly evolved over time. Since the Montreal 1976 Games, there have been two lifts used in competition: the snatch and the clean and jerk. In the snatch, the bar is lifted from the floor to above the head in one movement. By contrast, the clean and jerk is a two-stage action: the bar is first brought up to the shoulders before being jerked over the head. These extremely demanding exercises require exceptional physical strength and ironclad mental resolve. Today, competitors perform both lifts three times, and their best result in each lift are combined to determine their overall score. The competitor with the highest total score is declared the winner. Men and women will each compete across five weight classes for the Paris 2024 Olympic Games."},
                new Sport {Id = 7, Name = "Judo", Description = "The objective of judo is to throw your opponent to the ground, immobilise them with a pinning hold or force them into submission with a joint lock or choke. There are two types of scores in judo: An ippon is awarded when an athlete throws his opponent to the mat on his or her back with strength, speed and control. An ippon can also be awarded through submission or by pinning an opponent to the ground for 20 seconds. If a judoka achieves ippon, they immediately win the match. A waza-ari is awarded for a throw that isn’t clear enough to be an ippon (either because it lacked speed or force, or the opponent did not land primarily on their back) or when an   opponent is pinned down for less than 20 seconds (but longer than 10 seconds). Two waza‑ari in one match is the equivalent of an ippon and immediately ends the match. Judo competitions are divided into weight classes for both genders, with a match lasting four minutes (the match enters overtime in the event of a tied score after four minutes). Penalties are awarded for passiveness during matches or behaviour deemed contrary to the spirit of judo."},
                new Sport {Id = 8, Name = "Artistic Gymnastics", Description = ""},
                new Sport {Id = 9, Name = "Rowing", Description = ""},
                new Sport {Id = 10, Name = "Boxing", Description = ""},
                new Sport {Id = 11, Name = "Wrestling", Description = ""},
                new Sport {Id = 12, Name = "Sailing", Description = ""},
                new Sport {Id = 13, Name = "Fencing", Description = ""},
                new Sport {Id = 14, Name = "Table Tennis", Description = ""},
                new Sport {Id = 15, Name = "Marathon Swimming", Description = ""},
                new Sport {Id = 16, Name = "Canoe Sprint", Description = ""},
                new Sport {Id = 17, Name = "Cycling Road", Description = ""},
                new Sport {Id = 18, Name = "Karate", Description = ""},
                new Sport {Id = 19, Name = "Canoe Slalom", Description = ""},
                new Sport {Id = 20, Name = "Handball", Description = ""},
                new Sport {Id = 21, Name = "Equestrian", Description = ""},
                new Sport {Id = 22, Name = "Hockey", Description = ""},
                new Sport {Id = 23, Name = "Football", Description = ""},
                new Sport {Id = 24, Name = "Rugby Sevens", Description = ""},
                new Sport {Id = 25, Name = "Beach Volleyball", Description = ""},
                new Sport {Id = 26, Name = "Tennis", Description = ""},
                new Sport {Id = 27, Name = "Triathlon", Description = ""},
                new Sport {Id = 28, Name = "Basketball", Description = ""},
                new Sport {Id = 29, Name = "Volleyball", Description = ""},
                new Sport {Id = 30, Name = "Cycling Mountain Bike", Description = ""},
                new Sport {Id = 31, Name = "Golf", Description = ""},
                new Sport {Id = 32, Name = "Cycling BMX Racing", Description = ""},
                new Sport {Id = 33, Name = "Surfing", Description = ""},
                new Sport {Id = 34, Name = "Modern Pentathlon", Description = ""},
                new Sport {Id = 35, Name = "Rhythmic Gymnastics", Description = ""},
                new Sport {Id = 36, Name = "Water Polo", Description = ""},
                new Sport {Id = 37, Name = "Cycling Track", Description = ""},
                new Sport {Id = 38, Name = "Archery", Description = ""},
                new Sport {Id = 39, Name = "Artistic Swimming", Description = ""},
                new Sport {Id = 40, Name = "Badminton", Description = ""},
                new Sport {Id = 41, Name = "Trampoline Gymnastics", Description = ""},
                new Sport {Id = 42, Name = "Baseball/Softball", Description = ""},
                new Sport {Id = 43, Name = "Cycling BMX Freestyle", Description = ""},
                new Sport {Id = 44, Name = "Diving", Description = ""},
                new Sport {Id = 45, Name = "Sport Climbing", Description = ""},
                new Sport {Id = 46, Name = "Skateboarding", Description = ""},
                new Sport {Id = 47, Name = "3x3 Basketball", Description = ""},
            });
            #endregion

            #region Statistic
            try
            {
                List<Statistic> tmp = new();
                string json = File.ReadAllText("Statistic.json");
                List<Statistic> statistics = JsonConvert.DeserializeObject<List<Statistic>>(json);
                if (statistics != null || statistics.Count > 0)
                {
                    foreach (Statistic player in statistics)
                    {
                        tmp.Add(player);
                    }
                }
                modelBuilder.Entity<Statistic>().HasData(new List<Statistic>(tmp));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region PlayerStatistic
            try
            {
                List<PlayerStatistic> tmp = new();
                string json = File.ReadAllText("StatisticPlayer.json");
                List<PlayerStatistic> playerStatistics = JsonConvert.DeserializeObject<List<PlayerStatistic>>(json);
                if (playerStatistics != null || playerStatistics.Count > 0)
                {
                    foreach (PlayerStatistic player in playerStatistics)
                    {
                        tmp.Add(player);
                    }
                }
                modelBuilder.Entity<PlayerStatistic>().HasData(new List<PlayerStatistic>(tmp));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            //#region PlayerOlimpicGame
            //try
            //{
            //    List<PlayerOlimpicGame> tmp = new();
            //    string json = File.ReadAllText("Statistic.json");
            //    List<PlayerOlimpicGame> playerOlimpicGames = JsonConvert.DeserializeObject<List<PlayerOlimpicGame>>(json);
            //    if (playerOlimpicGames != null || playerOlimpicGames.Count > 0)
            //    {
            //        foreach (PlayerOlimpicGame player in playerOlimpicGames)
            //        {
            //            tmp.Add(player);
            //        }
            //    }
            //    modelBuilder.Entity<PlayerOlimpicGame>().HasData(new List<PlayerOlimpicGame>(tmp));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //#endregion

            #region OlimpicGame
            modelBuilder.Entity<OlimpicGame>().HasData(new OlimpicGame[]
            {
                new OlimpicGame {Id = 1, PlaceId = 1},
            });
            #endregion

        }
    }
}
