using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomSorting 
{
    [Preserve(AllMembers = true)]
    class ListViewContactsInfoRepository
    {
        #region Fields

        private Random random = new Random(1234567890);

        #endregion

        #region Constructor

        public ListViewContactsInfoRepository()
        {

        }

        #endregion

        #region Get Contacts Details

        public ObservableCollection<ListViewContactsInfo> GetContactDetails(int count)
        {
            ObservableCollection<ListViewContactsInfo> customerDetails = new ObservableCollection<ListViewContactsInfo>();
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            for (int i = 0; i < CustomerNames.Count(); i++)
            {
                var details = new ListViewContactsInfo()
                {
                    ContactType = contactType[random.Next(0, 5)],
                    ContactNumber = random.Next(100, 400).ToString() + "-" + random.Next(500, 800).ToString() + "-" + random.Next(1000, 2000).ToString(),
                    ContactName = CustomerNames[i],
                    ContactImage = ImageSource.FromResource("CustomSorting.Images.Image" + (i % 19) + ".png", assembly),
                };
                customerDetails.Add(details);
            }
            return customerDetails;
        }

        #endregion

        #region Contacts Information

        string[] contactType = new string[]
        {
            "HOME",
            "WORK",
            "MOBILE",
            "OTHER",
            "BUSINESS"
        };

        string[] CustomerNames = new string[]
        {
            "Kyle",
            "Gina",
            "Liz",
            "Larry",
            "Katie",
            "Liam",
            "Irene",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Holly",
            "Jennifer",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan",
            "Caleb",
            "Caden",
            "Jack",
            "Ryan",
            "Connor",
            "Michael",
            "Elijah",
            "Brayden",
            "Benjamin",
            "Nicholas",
            "Alexander",
            "William",
            "Matthew",
            "James",
            "Landon",
            "Nathan",
            "Dylan",
            "Evan",
            "Luke",
            "Andrew",
            "Gabriel",
            "Gavin",
            "Joshua",
            "Owen",
            "Daniel",
            "Carter",
            "Tyler",
            "Cameron",
            "Christian",
            "Wyatt",
            "Henry",
            "Eli",
            "Joseph",
            "Max",
            "Isaac",
            "Samuel",
            "Anthony",
            "Grayson",
            "Zachary",
            "David",
            "Christopher",
            "John",
            "Isaiah",
            "Levi",
            "Jonathan",
            "Oliver",
            "Chase",
            "Cooper",
            "Tristan",
            "Colton",
            "Austin",
            "Colin",
            "Charlie",
            "Dominic",
            "Parker",
            "Hunter",
            "Thomas",
            "Alex",
            "Ian",
            "Jordan",
            "Cole",
            "Julian",
            "Aaron",
            "Carson",
            "Miles",
            "Blake",
            "Brody",
            "Adam",
            "Sebastian",
            "Adrian",
            "Nolan",
            "Sean",
            "Riley",
            "Bentley",
            "Xavier",
            "Hayden",
            "Jeremiah",
            "Jason",
            "Jake",
            "Asher",
            "Micah",
            "Jace",
            "Brandon",
            "Josiah",
            "Hudson",
            "Nathaniel",
            "Bryson",
            "Ryder",
            "Justin",
            "Bryce",
        };

        #endregion
    }
}
