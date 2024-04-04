using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class Quiz : Evaluation
    {
        // Constructor
        public Quiz(Course course, byte weight, uint numberOfQuestions = 1) : base(course, EvaluationType.Quiz, weight)
        {
            this.NumberOfQuestions = numberOfQuestions;
        }
        // Property #1
        public uint NumberOfQuestions { get; set; }
        // Action member #1
        public override string ToString()
        {
            return $"{base.ToString()}, Number of Questions: {NumberOfQuestions}";
        }
    }
}
