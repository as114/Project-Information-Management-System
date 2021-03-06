//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectInformationManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class capture_data
    {
        public int captureRecordId { get; set; }

        [Required(ErrorMessage = " ")]
        public string gcl_id { get; set; }

        [Required(ErrorMessage = " ")]
        public int project_id { get; set; }

        [Required(ErrorMessage = " ")]
        public string sample_id { get; set; }

        [Required(ErrorMessage = " ")]
        public string capture_type { get; set; }

        [Required(ErrorMessage = " ")]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "number or double value")]
        public double input_amount { get; set; }

        [Required(ErrorMessage = " ")]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "number or double value")]
        public double concentration { get; set; }

        [Required(ErrorMessage = " ")]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "number or double value")]
        public double nm_concentration { get; set; }

        [Required(ErrorMessage = " ")]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "number or double value")]
        public double total_volume { get; set; }

        [Required(ErrorMessage = " ")]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "number or double value")]
        public double total_amount { get; set; }

        [Required(ErrorMessage = " ")]
        public System.DateTime date_made { get; set; }

        [Required(ErrorMessage = " ")]
        public string made_by { get; set; }

        [Required(ErrorMessage = " ")]
        public string qc_status { get; set; }
    }
}
