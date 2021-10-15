using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Entities
{

    public enum Gender
    {
        Male,
        Female
    }

    //[Table("TblPeople", Schema = "Person")]
    public class Person
    {
        //[Key]
        public Nullable<int> id { get; set; }

        //[Required, MaxLength(50), Column(TypeName = "nvarchar(50)")]
        public string  LastName { get; set; }

        //[Required, MaxLength(70), Column(TypeName = "nvarchar(70)")]
        public string FirstName { get; set; }
        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        //[Required, MaxLength(100), Column("EmailAddress", TypeName = "nvarchar(100)")]
        public string Email { get; set; }   

        public Store StoreWhereEmployee { get; set; }
    }
}
