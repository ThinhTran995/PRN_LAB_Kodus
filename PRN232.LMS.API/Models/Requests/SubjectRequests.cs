namespace PRN232.LMS.API.Models.Requests;

public class CreateSubjectRequest
{
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
    public int Credit { get; set; }
}

public class UpdateSubjectRequest
{
    public string SubjectCode { get; set; } = null!;
    public string SubjectName { get; set; } = null!;
    public int Credit { get; set; }
}

public class PatchSubjectRequest
{
    public string? SubjectCode { get; set; }
    public string? SubjectName { get; set; }
    public int? Credit { get; set; }
}
