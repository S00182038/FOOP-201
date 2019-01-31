using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Newtonsoft.Json;
/*
    Create a XAML interface as shown below.  This should display a list of accounts.  Use the helper code
    from Moodle which has an Account class and a method to create a number of Account objects to populate the Listbox with the account details.
    Selecting an account from the list will display account details in the Account Details TextBlock
    You should be able to add and remove accounts from the list.  To add use the TextBoxes at the bottom of the screen.  
    The combo box is for the Account Type.
    You should be able to search for accounts by account holder using the search box
    You should be able to filter accounts by the type of account using the checkboxes – Current, Savings, Student.
    Clicking on the set review dates button will set a review date for each account. This should be a random date in the next 12 months. 
    You need to update the GetAccountDetails method in the class to show the review date.
    Have the data save to a JSON file every 30 seconds.  This should be in the bin\debug directory
 */
namespace WPF_Exam_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Path = "accounts.json";
        ObservableCollection<Account> accounts;
        ObservableCollection<Account> filteredAccounts = new ObservableCollection<Account>();

        //Main Window
        public MainWindow()
        {
            InitializeComponent();
        }

        //when window loading is called
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {        
            //set source of list box
            accounts = new ObservableCollection<Account>();
            Account acc1 = new Account(
                                           "Joe Bloggs",
                                            "45670987",
                                            "Current",
                                            1000m
                                        );
          
            Account acc2 = new Account()
            {
                AccountHolder = "Sally Jones",
                AccountNumber = "43470959",
                AccountType = "Current",
                Balance = 500m,
               
            };

            Account acc3 = new Account()
            {
                AccountHolder = "Jim Smith",
                AccountNumber = "72057823",
                AccountType = "Savings",
                Balance = 5000m,
              
            };

            Account acc4 = new Account()
            {
                AccountHolder = "Joe Bloggs",
                AccountNumber = "90807652",
                AccountType = "Savings",
                Balance = 650.56m,
           
            };

            Account acc5 = new Account()
            {
                AccountHolder = "Louise Dolan",
                AccountNumber = "87267575",
                AccountType = "Student",
                Balance = 100.05m,
            };

            Account acc6 = new Account()
            {
                AccountHolder = "Milly Durcan",
                AccountNumber = "79530812",
                AccountType = "Student",
                Balance = 250m,
            };

            accounts.Add(acc1);
            accounts.Add(acc2);
            accounts.Add(acc3);
            accounts.Add(acc4);
            accounts.Add(acc5);
            accounts.Add(acc6);

            lbxAccounts.ItemsSource = accounts;

            //populate combo box
            string[] accountTypes = { "Current", "Student", "Savings" };
            cbxType.ItemsSource = accountTypes;
            cbxType.SelectedIndex = 0;

            //set timer randomly
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += Dt_Tick;
            dt.Interval = new TimeSpan(0,0,5);
            dt.Start();
        }
        //Saving accounts into JASON 
        private void Dt_Tick(object sender, EventArgs e)
        {
            //write list to file
            string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);

            //write to file
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(json);
            }
            //Testing for file handling
            //MessageBox.Show("Accounts Saved ");
        }
        //Display account details on the right list box
        private void lbxAccounts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account account = lbxAccounts.SelectedItem as Account;
            if (account != null)
            {
                tbxAcountDetails.Text = account.DisplayAccountDetails();
            }
            else
            {
                tbxAcountDetails.Text = "";
            }     
        }

        //adding new customer account
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Account newAccount = new Account();
            newAccount.AccountNumber = tbxAccountNumber.Text;
            newAccount.AccountHolder = tbxAccountHolder.Text;
            newAccount.AccountType = cbxType.SelectedItem as string;
            string bal = tbxOpeningBalance.Text;
            newAccount.Balance = Convert.ToDecimal(bal);

            accounts.Add(newAccount);
            MessageBox.Show("New Account Added ");

            //tbxOpeningBalance.Text = "";
            //tbxAccountHolder.Text = "";
            //tbxAccountNumber.Text = "";
        }
        //Remove account from list
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // determine account
            Account selectedAccount = lbxAccounts.SelectedItem as Account;
            //account selected
            if (selectedAccount != null)
            {
                //remove
                accounts.Remove(selectedAccount);
            }
        }
        //Random date for review 
        private void btnReviewDate_Click(object sender, RoutedEventArgs e)
        {           
            Random gen = new Random();
            int range = 1 * 365; //1 year  
            DateTime randomDate = DateTime.Today.AddDays(gen.Next(range));
            randomDate.ToShortDateString();
            Account.Date = randomDate;
            MessageBox.Show("Added new Review date");
        }
        //searching based on the name of account holder
        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTerm = tbxSearch.Text.ToLower();
            lbxAccounts.ItemsSource = accounts.Where(m => m.AccountHolder.ToLower().Contains(searchTerm));
        }

        #region Check Boxes
        private void Current_Checked(object sender, RoutedEventArgs e)
        {        
            string searchCurrrent = "Current".ToLower();
            lbxAccounts.ItemsSource = accounts.Where(m => m.AccountType.ToLower().Contains(searchCurrrent));
        }

        private void Student_Checked(object sender, RoutedEventArgs e)
        {
            string searchStudent = "Student".ToLower();
            lbxAccounts.ItemsSource = accounts.Where(a => a.AccountType.ToLower().Contains(searchStudent));
        }

        private void Savings_Checked(object sender, RoutedEventArgs e)
        {
            string searchSavings = "Savings".ToLower();
            lbxAccounts.ItemsSource = accounts.Where(a => a.AccountType.ToLower().Contains(searchSavings));
        }

        private void Current_Unchecked(object sender, RoutedEventArgs e)
        {
            lbxAccounts.ItemsSource = accounts;
        }

        private void Student_Unchecked(object sender, RoutedEventArgs e)
        {
            lbxAccounts.ItemsSource = accounts;
        }

        private void Savings_Unchecked(object sender, RoutedEventArgs e)
        {
            lbxAccounts.ItemsSource = accounts;
        }
        #endregion
    }
}
