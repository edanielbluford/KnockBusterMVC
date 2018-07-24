using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnockBusterMVC
{
    [MetadataType(typeof(Rentalmetadata))]
    public partial class Rental
    {
    }
    public class Rentalmetadata
    {
        public int RentalID { get; set; }
        [DisplayName("Customer")]
        public Nullable<int> CustomerID { get; set; }
        [DisplayName("Movie")]
        public Nullable<int> MovieID { get; set; }
        public Nullable<System.DateTime> RentalDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movy Movy { get; set; }
    }
}