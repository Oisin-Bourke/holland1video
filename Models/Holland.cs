using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//defining the schema

namespace RazorPagesHolland.Models
{
    public class Holland
    {

        public int ID { get; set; }//primary key

        [Display(Name ="Vessel Name")]
        public string VesselName { get; set; }

        [Display(Name = "ROV Dive Name")]
        public string ROVDiveName { get; set; }

        public string Location { get; set; }

        [Display(Name = "Dive Date")]
        [DataType(DataType.Date)]
        public DateTime DiveDate { get; set; }

        [Display(Name = "Video")]
        //[DataType(DataType.Url)]
        public string VideoUrl { get; set; }

        [Column(TypeName = "float(10, 6)")]
        public float Latitude { get; set; }

        [Column(TypeName = "float(10, 6)")]
        public float Longitude { get; set; }

    }
}
