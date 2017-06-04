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
        public async Task<List<Subject>> GetListSubjectsAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Subject_GetList"))
            {
                var listParams  = new Dictionary<string, object>();
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

        public Task<List<Subject>> GetListSubjectByUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
