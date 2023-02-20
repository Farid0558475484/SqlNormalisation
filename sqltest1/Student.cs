using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sqltest1


{
    public class Student
    {

        [Key,ForeignKey(nameof(SosialPage))]

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        //public int SosialPageId { get; set; }
        public SosialPage SosialPage { get; set; }
        




    }
}
