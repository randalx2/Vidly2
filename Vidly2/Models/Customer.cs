using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }  

        //Navigation property
        public MembershipType MembershipType { get; set; }

        //Foreign Key
        //EF recognizes this convention and treats this property as a foreign key
        public byte MembershipTypeId { get; set; }  

    }
}