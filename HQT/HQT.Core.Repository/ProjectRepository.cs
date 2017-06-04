using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT.Core.Repository
{
    public class ProjectRepository:IProjectRepository
    {
        public async Task<List<BaseProject>> GetListProjectsAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetList"))
            {
                var listParams = new Dictionary<string, object>();

                var result = await db.ExecuteReaderAsync(listParams);
                var listProjects = new List<BaseProject>();
                while (result.Read())
                {
                    var id = result["Id"].GetGuid();
                    var projectName = result["ProjectName"].GetString();
                    var registerFrom = result["RegisterFrom"].GetDateTime();
                    var registerTo = result["RegisterTo"].GetDateTime();
                    var deadline = result["Deadline"].GetDateTime();
                    var subjectName = result["CourseName"].GetString();
                    var limit = result["GroupCapacity"].GetInt32();
                    var upperThreshold = result["StudentMax"].GetInt32();
                    var projectType = result["ProjectTypeName"].GetString();
                    Enum.TryParse(projectType, out ProjectTypes projectTypeEnum);

                    var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                        deadline, projectTypeEnum, subjectName, upperThreshold);
                    if (project != null)
                        listProjects.Add(project);
                }
                return listProjects;
            }

        }

        public Task<BaseProject> GetProjectDetailAsync(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BaseProject>> GetListProjectBySubjectAsync(Guid subjectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetListBySubject"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(subjectId), subjectId}
                };

                var result = await db.ExecuteReaderAsync(listParams);
                var listProjects = new List<BaseProject>();
                while (result.Read())
                {
                    var id = result["Id"].GetGuid();
                    var projectName = result["ProjectName"].GetString();
                    var registerFrom = result["RegisterFrom"].GetDateTime();
                    var registerTo = result["RegisterTo"].GetDateTime();
                    var deadline = result["Deadline"].GetDateTime();
                    var subjectName = result["CourseName"].GetString();
                    var limit = result["GroupCapacity"].GetInt32();
                    var upperThreshold = result["StudentMax"].GetInt32();
                    var projectType = result["ProjectTypeName"].GetString();
                    Enum.TryParse(projectType, out ProjectTypes projectTypeEnum);

                    var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                        deadline, projectTypeEnum, subjectName, upperThreshold);
                    if (project != null)
                        listProjects.Add(project);
                }
                return listProjects;
            }
        }

        public async Task<bool> CreateProjectAsync(BaseProject project, Guid subjectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_Add"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(project.Id), project.Id},
                    {nameof(project.ProjectName), project.ProjectName },
                    {nameof(project.Deadline), project.Deadline },
                    {nameof(project.RegisterFrom) , project.RegisterFrom },
                    {nameof(project.RegisterTo), project.RegisterTo },
                    {nameof(project.Limit), project.Limit }
                };
                var team = project as ProjectForTeam;
                if (team != null)
                {
                    var studentMax = team.UpperThreshold;
                    listParams.Add(nameof(studentMax), studentMax);
                }
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<bool> DeleteProjectAsync(Guid projectId, Guid subjectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_Delete"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(projectId), projectId},
                    {nameof(subjectId), subjectId}
                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }
    }
}
