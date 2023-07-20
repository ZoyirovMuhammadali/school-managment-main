using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Exceptions.TeacherAttends;

public class TeacherAttendsNotFoundException:NotFoundException
{
    public TeacherAttendsNotFoundException()
    {
        this.TitleMessage = "TeacherAttends Not found ";
    }
}
