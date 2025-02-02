﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }

        [Column("Question")]
        public string QuestionString { get; set; }
    }
}
