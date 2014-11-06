using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Benchmark
    {
        public Benchmark()
        {
            this.Questions = new List<Question>();
            this.QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public short BenchmarkID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
