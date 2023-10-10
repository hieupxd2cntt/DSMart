using System.ComponentModel.DataAnnotations;

namespace DSMartEntities.Entities
{
    public class ALLCODE
    {
        
        public decimal IDX { get; set; }
        [Key]
        public string CODE_NAME { get; set; }

        public string TYPE_NAME { get; set; }

        public string DEP_CODE { get; set; }

        public string CODE_VAL { get; set; }

        public string CONTENTS { get; set; }

        public bool MODIFY { get; set; }

        public bool ISDEFAULT { get; set; }

        public int RSR_ID { get; set; }

        public bool STATUS { get; set; }

    }
}