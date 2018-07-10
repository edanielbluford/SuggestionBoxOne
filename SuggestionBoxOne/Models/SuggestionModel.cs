using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBoxOne.Models
{
    public class SuggestionModel

    {
        [Key]
        public int RecordNum { get; set; }


        public string SuggestionName { get; set; }
        public String SuggestionComment { get; set; }
    }
}