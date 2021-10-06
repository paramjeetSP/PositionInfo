﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class AssessmentRevision
    {
        public AssessmentRevision()
        {
            AssessmentCriteria = new HashSet<AssessmentCriterion>();
        }

        public int Id { get; set; }
        public string RevisionCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<AssessmentCriterion> AssessmentCriteria { get; set; }
    }
}
