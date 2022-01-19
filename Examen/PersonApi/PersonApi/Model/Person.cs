using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Model
{

    [Table("TblPeople", Schema = "dbo")]
    public class Person
    {
        [Key]
        public int id { get; set; }

        [Required, MaxLength(50), Column(TypeName = "nvarchar(50)")]
        public String FirstName { get; set; }

        [Required, MaxLength(50), Column(TypeName = "nvarchar(50)")]
        public String LastName { get; set; }
        public int gender { get; set; }

        [Required, MaxLength(100), Column("EmailAddress", TypeName = "nvarchar(100)")]
        public String mail { get; set; }

        public Person(int id, string firstName, string lastName, int gender, string mail)
        {
            this.id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.gender = gender;
            this.mail = mail;
        }
            
        public Person()
        {
        }
    }
}
