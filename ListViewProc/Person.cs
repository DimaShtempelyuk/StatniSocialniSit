using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ListViewProc
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname"));
            }
        }
        private DateTime _dob;
        public DateTime Dob
        {
            get => _dob;
            set
            {
                _dob = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dob"));
            }
        }
        private string _rc;
        public string Rc
        {
            get => _rc;
            set
            {
                _rc = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tuition"));
            }
        }
        public static Dictionary<string, Person> AllPersons = new Dictionary<string, Person>();
        public static void InitPersons()
        {
            AllPersons["AndrejR1ch"] = new Person
            {
                Name = "Andrej",
                Surname = "Zlatý",
                Dob = new DateTime (2000,01,01),
                Rc = "440514/0145/8"

            };
            AllPersons["NikiTank"] = new Person
            {
                Name = "Nikita",
                Surname = "Blatný",
                Dob = new DateTime(1998,05,13),
                Rc = "862476/5456/7"
            };
            AllPersons["Honzik"] = new Person
            {
                Name = "Jan",
                Surname = "Novák",
                Dob = new DateTime(2002,03,04),
                Rc = "238462/3245/9"
            };
        }
    }
}
