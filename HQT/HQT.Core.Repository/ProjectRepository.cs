using System;
using System.Collections.Generic;
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
                    var id = result["ProjectId"].GetGuid();
                    var projectName = result["ProjectName"].GetString();
                    var registerFrom = result["RegisterFrom"].GetDateTime();
                    var registerTo = result["RegisterTo"].GetDateTime();
                    var deadline = result["Deadline"].GetDateTime();
                    var subjectName = result["CourseName"].GetString();
                    var limit = result["GroupCapacity"].GetInt32();
                    var upperThreshold = result["StudentMax"].GetInt32();
                    var projectType = result["ProjectTypeName"].GetString();
                    var type = upperThreshold > 1 ? ProjectTypes.Team : ProjectTypes.Person;

                    var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                        deadline, type, subjectName, upperThreshold, projectType);
                    if (project != null)
                        listProjects.Add(project);
                }
                return listProjects;
            }

        }

        public async Task<BaseProject> GetProjectDetailAsync(Guid projectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetDetail"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(projectId), projectId}
                };

                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                {
                    var id = result["ProjectId"].GetGuid();
                    var projectName = result["ProjectName"].GetString();
                    var registerFrom = result["RegisterFrom"].GetDateTime();
                    var registerTo = result["RegisterTo"].GetDateTime();
                    var deadline = result["Deadline"].GetDateTime();
                    var limit = result["GroupCapacity"].GetInt32();
                    var upperThreshold = result["StudentMax"].GetInt32();
                    var projectType = result["ProjectTypeName"].GetString();
                    var type = upperThreshold > 1 ? ProjectTypes.Team : ProjectTypes.Person;

                    var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                        deadline, type, "", upperThreshold, projectType);
                    return project;
                }
                return null;
            }
        }

        public async Task<List<BaseProject>> GetListProjectBySubjectAsync(Guid courseId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetListByCourseId"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(courseId), courseId}
                };

                var result = await db.ExecuteReaderAsync(listParams);
                var listProjects = new List<BaseProject>();
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();
                    while (next && result.Read())
                    {
                        var id = result["ProjectId"].GetGuid();
                        var projectName = result["ProjectName"].GetString();
                        var registerFrom = result["RegisterFrom"].GetDateTime();
                        var registerTo = result["RegisterTo"].GetDateTime();
                        var deadline = result["Deadline"].GetDateTime();
                        var subjectName = result["CourseName"].GetString();
                        var limit = result["GroupCapacity"].GetInt32();
                        var upperThreshold = result["StudentMax"].GetInt32();
                        var projectType = result["ProjectTypeName"].GetString();
                        var type = upperThreshold > 1 ? ProjectTypes.Team : ProjectTypes.Person;

                        var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                            deadline, type, subjectName, upperThreshold, projectType);
                        if (project != null)
                            listProjects.Add(project);
                    }
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
                    {nameof(project.Limit), project.Limit },
                    {nameof(subjectId), subjectId },
                    {"ProjectTypeName", project.ProjectType }
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

        public async Task<List<BaseProject>> GetListProjectCanRegisterAsync(Guid courseId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetCanRegister"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(courseId), courseId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listProjects = new List<BaseProject>();
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();
                    while (next && result.Read())
                    {
                        var id = result["ProjectId"].GetGuid();
                        var projectName = result["ProjectName"].GetString();
                        var registerFrom = result["RegisterFrom"].GetDateTime();
                        var registerTo = result["RegisterTo"].GetDateTime();
                        var deadline = result["Deadline"].GetDateTime();
                        var subjectName = result["CourseName"].GetString();
                        var limit = result["GroupCapacity"].GetInt32();
                        var upperThreshold = result["StudentMax"].GetInt32();
                        var projectType = result["ProjectTypeName"].GetString();
                        var type = upperThreshold > 1 ? ProjectTypes.Team : ProjectTypes.Person;

                        var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                            deadline, type, subjectName, upperThreshold, projectType);
                        if (project != null)
                            listProjects.Add(project);
                    }
                }
                return listProjects;
            }
        }

        public async Task<List<BaseProject>> GetListProjectCanNotRegisterAsync(Guid courseId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetCannotRegister"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(courseId), courseId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listProjects = new List<BaseProject>();
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();
                    while (next && result.Read())
                    {
                        var id = result["ProjectId"].GetGuid();
                        var projectName = result["ProjectName"].GetString();
                        var registerFrom = result["RegisterFrom"].GetDateTime();
                        var registerTo = result["RegisterTo"].GetDateTime();
                        var deadline = result["Deadline"].GetDateTime();
                        var subjectName = result["CourseName"].GetString();
                        var limit = result["GroupCapacity"].GetInt32();
                        var upperThreshold = result["StudentMax"].GetInt32();
                        var projectType = result["ProjectTypeName"].GetString();
                        var type = upperThreshold > 1 ? ProjectTypes.Team : ProjectTypes.Person;

                        var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                            deadline, type, subjectName, upperThreshold, projectType);
                        if (project != null)
                            listProjects.Add(project);
                    }
                }
                return listProjects;
            }
        }

        public async Task<List<ProjectType>> GetListProjectTypeAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_ProjectType_GetList"))
            {
                var listParams = new Dictionary<string,object>();
                var result = await db.ExecuteReaderAsync(listParams);
                var listProjectTypes = new List<ProjectType>();
                while (result.Read())
                {
                    var id = result["ProjectTypeId"].GetGuid();
                    var name = result["ProjectTypeName"].GetString();
                    var projectType = new ProjectType(name, id);
                    listProjectTypes.Add(projectType);
                }
                return listProjectTypes;
            }
        }

        public async Task<bool> SaveProjectInformationAsync(BaseProject project)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_Change"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {"projectId", project.Id},
                    {"EndSubmit", project.Deadline },
                    {"StartRegister" , project.RegisterFrom },
                    {"EndRegister", project.RegisterTo },
                    {"GroupCapacity", project.Limit },
                    {"ProjectType", project.ProjectType },
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

        public async Task<bool> RemoveTopicAsync(Guid topicId, Guid projectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_Project_Delete"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(topicId), topicId },
                    {nameof(projectId), projectId }
                };

                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<Tuple<int,List<BaseProject>>> GetListPraceticeProjectAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_GetListPractice"))
            {
                var listParams = new Dictionary<string, object>();
                var result = await db.ExecuteReaderAsync(listParams);
                var listProjects = new List<BaseProject>();
                var count = 0;
                if (result.Read())
                {
                    count = result.GetInt32(0);
                    var next = result.NextResult();
                    while (next && result.Read())
                    {
                        var id = result["ProjectId"].GetGuid();
                        var projectName = result["ProjectName"].GetString();
                        var registerFrom = result["StartRegister"].GetDateTime();
                        var registerTo = result["EndRegister"].GetDateTime();
                        var deadline = result["EndSubmit"].GetDateTime();
                        var subjectName = result["CourseName"].GetString();
                        var limit = result["GroupCapacity"].GetInt32();
                        var upperThreshold = result["StudentMax"].GetInt32();
                        var projectType = result["ProjectTypeName"].GetString();
                        var type = upperThreshold > 1 ? ProjectTypes.Team : ProjectTypes.Person;

                        var project = ProjectFactory.CreateProject(id, projectName, registerFrom, registerTo, limit,
                            deadline, type, subjectName, upperThreshold, projectType);
                        if (project != null)
                            listProjects.Add(project);
                    }
                }
                return new Tuple<int, List<BaseProject>>(count, listProjects);
            }
        }

        public async Task<bool> IsRegisterProjectAsync(Guid projectId, Guid userId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_IsRegister"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(projectId), projectId },
                    {nameof(userId), userId }
                };
                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                    return true;
                return false;
            }
        }

        public async Task<bool> RenewEndSubmitDays(Guid projectId, int day)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_ExtendEndSubmit"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(projectId), projectId },
                    {nameof(day), day }
                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<bool> RenewEndRegisterDays(Guid projectId, int day)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Project_ExtendEndRegister"))
            {
                var listParams = new Dictionary<string, object>
                {
                    {nameof(projectId), projectId },
                    {nameof(day), day }
                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }
    }
}
