﻿using CapitalPlacementTask.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Domain.Entities
{
    public class ApplicationForm: BaseEntity<Guid>
    {
        public Guid ProgramDetailsId { get; set; }
       
        public PersonalInformation PersonalInformation { get; set; }       
        public Profile? Profile { get; set; }
    }

    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IDNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }
        public List<Question>? Question { get; set; }
    }

    public class Education
    {
        public string School { get; set; }
        public string Degree { get; set; }

        public string CourseName { get; set; }

        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool CurrentlyStudyingThere { get; set; }
       


    }
    public class Profile
    {

        public List<WorkExperience>? workExperiences { get; set; }

        public List<Education>? Education { get; set; }
    }
    public class WorkExperience
    {
        public string Company { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool CurrentlyWorkingThere { get; set; }

    }

    public class Question
    {
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public Choices Choices { get; set; }
        public DateTime? DateValue { get; set; }
        public double? NumberValue { get; set; }
    }


    public class Choices
    {
        public List<string> Options { get; set; }
    }

    public enum QuestionType
    {
        MultipleChoice,
        Date,
        Number,
        paragraph
    }
}
