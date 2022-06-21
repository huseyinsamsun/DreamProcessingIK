﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PersonnelDocuments : BaseEntity
    {
        [Required]
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileDetails { get; set; }
        public DateTime FileGeneratedDate { get; set; }
    }
}
