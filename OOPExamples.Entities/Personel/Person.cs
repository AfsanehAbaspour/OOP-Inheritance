using System;
using System.Collections.Generic;
using SadrTools.ExtensionMethods;

namespace OOPExamples.Entities.Personel
{
    /// <summary>
    /// کلاسی برای موجودیت اشخاص
    /// </summary>
    public class Person
    {

        #region [ Fields = فقط برای زمانی که میخوای برای ست کردن مقدار شرط و شروط بزاری ]
      
        // Naming Convention

        // AFirstName
        // MyFirstName
        // FFirstName

        //_f
        //Fi
        //fi
        private string _firstName;
        private string _lastName;
        private string _ssn;
        #endregion

        #region [ Property : public Pascal ]
        /// <summary>
        /// مقدار شناسه هر فرد - یونیک میباشد
        /// </summary>
        public int ID
        {
            get
            {
                return SadrTools.Utility.Utility.GetRandomNumber();
            }   
        }

        /// <summary>
        /// نام
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                _firstName = value.Length > 2 ? value : "DEFAULT FIRST NAME";
            }
        }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value.Length > 2 ? value : "DEFAULT LAST NAME";
            }
        }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime BirthDate
        {
            get;set;
        }

        /// <summary>
        /// کد ملی - حتما 10 رقمی
        /// </summary>
        public string SSN
        {
            get { return _ssn; }
            set 
            {
                _ssn = value.Length == 10 ? value : "";
                   // throw new Exception("کد ملی حتما باید 10 رقمی باشد") ; 
            }
        }

        /// <summary>
        /// جنسیت
        /// </summary>
        public bool Gender
        {
            get;set;
        }

        public EnMaritalStatus MaritalStatus { get; set; }





        #endregion

        #region [ Read - Only Property ]

        /// <summary>
        /// سن 
        /// </summary>
        public byte Age
        {
            get { return (byte)(DateTime.Now.Year - BirthDate.Year); }
        }


        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        public string Title
        {
            get
            {
                return Gender ? "Mr " : "Ms ";
            }
        }

        /// <summary>
        /// جنسیت + نام کامل
        /// </summary>
        public string TitleFullName
        {
            get
            {
                return Title + FullName;
            }
        }
      
        
        /// <summary>
        /// تاریخ تولد شمسی
        /// </summary>
        public string PersianBirthDate
        {
            get
            {
                return BirthDate.ToPersianDate();
            }
        }
        
        
        #endregion


       
        public Person(/* DEFAULT CTOR */)
        {
            FirstName = "";
            LastName = "";
            SSN = "0000000000";
            BirthDate = DateTime.Now.AddYears(-18);
            Gender = true;
            MaritalStatus = EnMaritalStatus.مجرد; 
        }

       

        public Person(string lastName ,  EnMaritalStatus maritalStatus) : this()
        {
            LastName = lastName;
            MaritalStatus = maritalStatus;
        }

        public Person( string firstName) : this()
        {
            FirstName = firstName;
        }

        public Person( string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person( string firstName, string lastName, string ssn) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }

        public Person( string firstName, string lastName, string ssn, DateTime birthDate) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            BirthDate = birthDate;
        }

        public Person( string firstName, 
                      string lastName, string ssn, 
                      DateTime birthDate, bool gender, 
                      EnMaritalStatus maritalStatus = EnMaritalStatus.نامزد) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            BirthDate = birthDate;
            Gender = gender;
            MaritalStatus = maritalStatus;
        }

        public override string ToString()
        {
            return ($"{ID} {TitleFullName} {BirthDate.ToLongDateString()} = {PersianBirthDate} = {Age} {SSN}");
        }       
    }
}