﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyLine.Models
{
    public class FlightSegment
    {
        [Key]
        [Required]

        public int Segment_ID_Pk { get; set; }

        [ForeignKey(nameof(Flight))]
        public int Flight_ID_Fk { get; set; }

        public int Segment_Order { get; set; }

        [ForeignKey(nameof(DepartureAirport))]
        public int Departure_Airport_ID_Fk { get; set; }

        [ForeignKey(nameof(ArrivalAirport))]
        public int Arrival_Airport_ID_Fk { get; set; }

        public DateTime Departure_Time { get; set; }
        public DateTime Arrival_Time { get; set; }

        public double Distance_KM { get; set; }
        public double Duration_Min { get; set; }

        public string? Aircraft_Type { get; set; }
        public double Layover_Duration_Min { get; set; }
        public double Distance_From_Origin { get; set; }
        public double Distance_To_Destination { get; set; }

        public Flight? Flight { get; set; }
        public AirPort? DepartureAirport { get; set; }
        public AirPort? ArrivalAirport { get; set; }
    }
}
