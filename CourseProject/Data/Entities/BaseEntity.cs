﻿using System.ComponentModel.DataAnnotations;

namespace CourseProject.Data.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
