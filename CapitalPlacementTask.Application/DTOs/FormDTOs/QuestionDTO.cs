using CapitalPlacementTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs.FormDTOs
{
    public class QuestionDTO
    {

        public QuestionType Type { get; set; }
        public MultipleChoiceDTO MultipleChoice { get; set; }

        public ParagraphDTO Paragraph { get; set; }

        public DropdownDTO Dropdown { get; set; }

        public YesOrNoDTO YesOrNo { get; set; }

    }


    public class MultipleChoiceDTO
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public bool EnableOthers { get; set; }
        public string MaxChoiceAllowed { get; set; }
    }

    public class ParagraphDTO
    {
        public string Question { get; set; }
    }


    public class DropdownDTO
    {
        public string Question { get; set; }
        public string Choices { get; set; }
        public bool EnableOthers { get; set; }
    }


    public class YesOrNoDTO
    {
        public string Question { get; set; }
        public bool DisqualifyCandidate { get; set; }
    }
}
