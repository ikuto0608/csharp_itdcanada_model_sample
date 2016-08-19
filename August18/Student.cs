using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August18
{
    class Student
    {
        static ADODB.Connection adoConnection = new ADODB.Connection();
        static ADODB.Recordset adoRecordset = new ADODB.Recordset();
        static String connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../../August18.accdb";

        public static string[] PROPERTY_NAMES = new string[] {"ID", "FIRST NAME", "LAST NAME", "ADDRESS", "PHONE", "PROGRAM"};

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _phone;
        private string _program;

        public Student(int id, string firstName, string lastName, string address, int phone, string program) {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phone = phone;
            _program = program;
        }

        public static List<Student> all()
        {
            adoConnection.Open(connectString);
            adoRecordset.Open("select * from students;", adoConnection);

            List<Student> students = new List<Student>();

            while (!adoRecordset.EOF)
            {
                Student student = new Student(
                    adoRecordset.Fields["id"].Value,
                    adoRecordset.Fields["first_name"].Value,
                    adoRecordset.Fields["last_name"].Value,
                    adoRecordset.Fields["address"].Value,
                    adoRecordset.Fields["phone"].Value,
                    adoRecordset.Fields["program"].Value
                );

                students.Add(student);
                adoRecordset.MoveNext();
            }
            adoConnection.Close();

            return students;
        }

        public bool save() {
            adoConnection.Open(connectString);
            if (isNew())
            {
                adoRecordset.Open("insert into students (first_name, last_name, address, phone, program) values ('" + this.FirstName + "', '" + this.LastName + "', '" + this.Address + "', " + this.Phone + ", '" + this.Program + "');", adoConnection);
            }
            else
            {
                String updateQuery = "update students set first_name = '" + this.FirstName + "', last_name = '" + this.LastName + "', address = '" + this.Address + "', phone = " + this.Phone + ", program = '" + this.Program + "' where id = " + this.ID + ";";
                adoRecordset.Open(updateQuery, adoConnection);
            }
            adoConnection.Close();
            return true;
        }

        public bool delete()
        {
            adoConnection.Open(connectString);
            adoRecordset.Open("delete from students where id = " + this.ID + ";", adoConnection);
            adoConnection.Close();

            return true;
        }

        private bool isNew()
        {
            if (this.ID != 0)
            {
                return false;
            }
            return true;
        }
        
        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public int Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        public string Program
        {
            get
            {
                return _program;
            }
            set
            {
                _program = value;
            }
        }
    }
}
