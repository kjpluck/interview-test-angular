using MediatR;
using StudentApi.Models.Students;
using StudentApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudentApi.Mediatr.Students
{
    public class AddStudentRequest : IRequest<AddStudentResponse>
    {

        public AddStudentRequest(Student newStudent)
        {
            NewStudent = newStudent;
        }

        public Student NewStudent { get; }
    }

    public class AddStudentResponse
    {
        public bool Success { get; set; }
    }

    public class AddStudentHandler : IRequestHandler<AddStudentRequest, AddStudentResponse>
    {
        private readonly IStudentsService studentsService;

        public AddStudentHandler(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }
        public Task<AddStudentResponse> Handle(AddStudentRequest request, CancellationToken cancellationToken)
        {
            var response = new AddStudentResponse
            {
                Success = this.studentsService.AddStudent(request.NewStudent)
            };

            return Task.FromResult(response);
            
        }
    }

}
