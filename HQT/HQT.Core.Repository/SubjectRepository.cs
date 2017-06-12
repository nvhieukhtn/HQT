using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT.Core.Repository
{
    public class SubjectRepository:ISubjectRepository
    {
        public async Task<Tuple<int, List<Subject>>> GetListSubjectsAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Course_GetAll"))
            {
                var listParams  = new Dictionary<string, object>();
                var result = await db.ExecuteReaderAsync(listParams);

                var listSubjects = new List<Subject>();
                var count = 0;
                if (result.Read())
                {
                    count = result.GetInt32(0);
                    var next = result.NextResult();

                    while (next && result.Read())
                    {
                        var id = result["CourseId"].GetGuid();
                        var subjectName = result["CourseName"].GetString();
                        var status = result["CourseStatus"].GetInt32();

                        var subject = new Subject(subjectName)
                        {
                            Id = id,
                            Status = status
                        };
                        listSubjects.Add(subject);
                    }
                }
                
                return new Tuple<int, List<Subject>>(count, listSubjects);
            }
        }

        public async Task<List<Subject>> GetListSubjectByUserAsync(Guid userId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Course_GetListByUser"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(userId), userId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listSubjects = new List<Subject>();
                while (result.Read())
                {
                    var id = result["CourseId"].GetGuid();
                    var subjectName = result["CourseName"].GetString();
                    var status = result["CourseStatus"].GetInt32();

                    var subject = new Subject(subjectName)
                    {
                        Id = id,
                        Status = status
                    };
                    listSubjects.Add(subject);
                }
                return listSubjects;
            }
        }

        public async Task<bool> CreateSubjectAsync(Subject subject)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Course_Add"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {"courseId", subject.Id },
                    {"CourseName", subject.SubjectName }
                };

                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<bool> AddUserIntoSubjectAsync(Guid userId, Guid courseId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Course_AddUser"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(userId), userId },
                    {nameof(courseId), courseId }
                };

                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }
    }
}
