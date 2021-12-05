using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PaddleApp.Models
{
    public class Paddle
    {
        [Key]
        public int loc_id { get; set; }
        public string location { get; set; }

    }
    public class Court
    {
        [Key]
        public int id { get; set; }
        public int  courtNumber { get; set; }
        [ForeignKey("paddle")]
        public int locID { get; set; }
        public Paddle paddle { get; set; }

    }

    public class Booking
    {
        [Key]
        public int id { get; set; }
        public int Duration { get; set; }
       
        public int start_time { get; set; }

        public int end_time { get; set; }

        [ForeignKey("court")]
        public int courtId { get; set; }
        public Court court { get; set; }

    }
}