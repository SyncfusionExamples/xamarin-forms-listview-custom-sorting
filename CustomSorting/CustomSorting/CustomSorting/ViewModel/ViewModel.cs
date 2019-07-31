using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.ListView.XForms;
using Xamarin.Forms.Internals;
using System.Windows.Input;

namespace CustomSorting 
{
    [Preserve(AllMembers = true)]
    public class ListViewSortingViewModel
    {
        #region Fields

        private ObservableCollection<ListViewContactsInfo> contactsInfo;

        #endregion

        #region Constructor

        public ListViewSortingViewModel()
        {
            GenerateSource(100);
            ButtonCommand = new Command<object>(OnButtonCommand);
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewContactsInfo> ContactsInfo
        {
            get { return contactsInfo; }
            set { this.contactsInfo = value; }
        }

        public ICommand ButtonCommand { get; set; }

        #endregion

        #region ItemSource

        public void GenerateSource(int count)
        {
            ListViewContactsInfoRepository contactRepository = new ListViewContactsInfoRepository();
            contactsInfo = contactRepository.GetContactDetails(count);
        }

        #endregion

        #region Commands

        private void OnButtonCommand(object obj)
        {
            Application.Current.MainPage.DisplayAlert("SfButton Command", "Command is raised", "Ok");
        }

        #endregion
    }
}
