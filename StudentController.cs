using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAllStudents());

    [HttpPost]
    public async Task<IActionResult> Post(Student student)
    {
        await _service.AddStudent(student);
        return Ok("Student Added");
    }

    [HttpPut]
    public async Task<IActionResult> Put(Student student)
    {
        await _service.UpdateStudent(student);
        return Ok("Student Updated");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteStudent(id);
        return Ok("Deleted");
    }
}