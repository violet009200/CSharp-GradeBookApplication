using System;
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool _isWeighted) : base(name, _isWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
