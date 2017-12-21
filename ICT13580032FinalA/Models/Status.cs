using System;
using SQLite;
namespace ICT13580032FinalA.Models
{
    public class Status
    {
        
            [NotNull]
        [PrimaryKey, AutoIncrement]
        [MaxLength(200)]
        public string Firstname
        {
            get;
            set;
        }
        [NotNull]
        [MaxLength(200)]
        public string LastName
        {
            get;
            set;
        }
        [NotNull]
        public int Age
        {
            get;
            set;
        }
        [NotNull]
        public string Gender
        {
            get;
            set;
        }
        [NotNull]
        public string Division
        {
            get;
            set;
        }
        [NotNull]
        public int Phone
        {
            get;
            set;
        }
        [NotNull]
        [MaxLength(200)]
        public string Mail
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        [NotNull]
        public string StatusMarry
        {
            get;
            set;
        }
        public int Childen
        {
            get;
            set;
        }
        [NotNull]
        public decimal Salary
        {
            get;
            set;
        }
    
    }
}
