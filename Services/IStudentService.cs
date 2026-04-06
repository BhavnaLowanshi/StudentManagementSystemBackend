using SchoolManagement.Api.DTOs;

namespace SchoolManagement.Api.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto?> GetStudentByIdAsync(int id);
        Task<StudentDto> AddStudentAsync(CreateStudentDto createStudentDto);
        Task<bool> UpdateStudentAsync(int id, UpdateStudentDto updateStudentDto);
        Task<bool> DeleteStudentAsync(int id);
    }
}
