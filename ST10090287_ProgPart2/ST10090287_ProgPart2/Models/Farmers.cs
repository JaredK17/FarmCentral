using ST10090287_ProgPart2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10090287_ProgPart2.Models
{
    public class Farmers
    {
        
        public string FARMER_ID { get; set; }
        public string FARMER_NAME { get; set; }
        public string FARMER_SURNAME { get; set; }
        public string FARMER_EMAIL { get; set; }
        public string FARMER_PASSWORD { get; set; }

        
        public Farmers(string fARMER_ID, string fARMER_NAME, string fARMER_SURNAME, string fARMER_EMAIL, string fARMER_PASSWORD)
        {
            FARMER_ID = fARMER_ID;
            FARMER_NAME = fARMER_NAME;
            FARMER_SURNAME = fARMER_SURNAME;
            FARMER_EMAIL = fARMER_EMAIL;
            FARMER_PASSWORD = fARMER_PASSWORD;
        }

        public Farmers()
        {
        }
    }
}
