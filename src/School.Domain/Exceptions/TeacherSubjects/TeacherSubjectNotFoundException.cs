using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Exceptions.TeacherSubjects;

public class TeacherSubjectNotFoundException:NotFoundException
{
    public TeacherSubjectNotFoundException()
    {
        this.TitleMessage = "TeacherSubject Not Found...";
    }
}
