﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Task")]
    public class ImportProjectTaskDto
    {
        [XmlElement("Name")]
        [Required]
        [MaxLength(GlobalConstants.TASK_NAME_MAX_LENGTH)]
        [MinLength(GlobalConstants.TASK_NAME_MIN_LENGTH)]

        public string Name { get; set; }

        [XmlElement("OpenDate")]
        [Required]
        public string TaskOpenDate { get; set; }

        [XmlElement("DueDate")]
        [Required]
        public string TaskDueDate { get; set; }

        [XmlElement("ExecutionType")]
        [Range(GlobalConstants.TASK_EXEC_TYPE_MIN_VALUE,GlobalConstants.TASK_EXEC_TYPE_MAX_VALUE)]
        public int ExecutionType { get; set; }

        [XmlElement("LabelType")]
        [Range(GlobalConstants.TASK_LABEL_TYPE_MIN_VALUE,GlobalConstants.TASK_LABEL_TYPE_MAX_VALUE)]

        public int LabelType { get; set; }
    }
}
