using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MotorEntity
    {
        public class ClientDetailINFO
        {

            public string ID_NUMBER { get; set; }

            public DateTime DOB { get; set; }

            public string HIJRI_DOB { get; set; }

            public string MOBILE_NO { get; set; }

            public string NAME { get; set; }

            public string GENDER { get; set; }

            public string ADDITIONAL_NUMBER { get; set; }

            public string BUILDING_NUMBER { get; set; }

            public string CITY { get; set; }

            public string DISTRICT { get; set; }

            public string POST_CODE { get; set; }

            public string STREET_NAME { get; set; }

            public string EMAIL_ID { get; set; }
            public string AGENT_ID { get; set; }
            public string NATIONALITY { get; set; }
            public string INSURANCE_PURPOSE { get; set; }


        }
        public class Paymentinfo
        {
            public DateTime EXPECTED_EFFECTIVE_DATE { get; set; }
            public decimal GROSS_PREMIUM { get; set; }
            public string CORE_SEGMENT_CODE { get; set; }
            public string SEQUENCE_NO { get; set; }
            public string PAYMENT_KEY { get; set; }
            public string CUSTOM_NO { get; set; }
            public decimal VAT { get; set; }
            public decimal NCD { get; set; }
            public decimal DISCOUNT { get; set; }
            public decimal NET_PREMIUM { get; set; }
            public decimal NCD_RATE { get; set; }
            public decimal ADDITIONALDISCOUNT { get; set; }
            public decimal LOYALTY { get; set; }
            public decimal NAJEMEEFEE { get; set; }
            public decimal SAMADISCOUNT { get; set; }
            public Int64 LOYALTYPLCID { get; set; }
            public int Customer_INFO_ID { get; set; }
            public string EDUCATION { get; set; }
            public int MILEAGE_EXPECTED_YEAR { get; set; }
            public int FcsCstId { get; set; }
            public int DOCUMENT_ID { get; set; }
        }
        public class NCD_Info_req
        {
            public string personId { get; set; }
            public int CUSTOMER_ID { get; set; }
            public string VehicleID { get; set; }
            public int VehicleIdentifier { get; set; }
        }
        public class NCD_Eligibility_req
        {
            public Int64 personId { get; set; }
            public Int64 vehicleId { get; set; }
            public int vehicleIdentifier { get; set; }
        }
        public class ADDITIONAL_VEHICAL_DETAILS
        {
            public string Current_Mileage { get; set; }
            public int Number_Of_Seats { get; set; }
            public string Transmission { get; set; }
            public string Location_Vehicle_kept_Overnight { get; set; }
            public int Anti_Theft_Alarm { get; set; }
            public int Anti_Lock_Braking { get; set; }
            public int Automatic_Braking { get; set; }
            public int Cruise_Control { get; set; }
            public int Adaptive_Cruise_Control { get; set; }
            public int Rear_Parking_Sensors { get; set; }
            public int Front_Sensors { get; set; }
            public int Rear_Camera { get; set; }
            public int Front_Camera { get; set; }
            public int Degree_Camera360 { get; set; }
            public int Customer_Id { get; set; }
            public string OFFICE_ADDRESS { get; set; }

            //Changes start made by raju on 26-12-2025
            public int Braking { get; set;}
            public int Acceleration { get; set;}
            public int Cornering { get; set;}
            public int Adherence_to_speed_limit { get; set;}
            public int Time_of_the_day { get; set;}
            public int Mileage { get; set;}
            public int Seat_belts { get; set;}
            //Changes end made by raju on 26-12-2025

        }

    }
}
