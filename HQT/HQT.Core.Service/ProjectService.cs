using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Interface.Service;
using HQT.Core.Model;

namespace HQT.Core.Service
{
    public class ProjectService:IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ITopicRepository _topicRepository;
        public ProjectService(IProjectRepository projectRepository, ITopicRepository topicRepository)
        {
            _projectRepository = projectRepository;
            _topicRepository = topicRepository;
        }
        public async Task<List<BaseProject>> GetListProjectsAsync()
        {
            var listProjects = await _projectRepository.GetListProjectsAsync();
            return listProjects;
        }

        public async Task<List<BaseProject>> GetListProjectBySubjectAsync(Guid subjectId)
        {
            var listProjects = await _projectRepository.GetListProjectBySubjectAsync(subjectId);
            return listProjects;
        }

        public async Task<bool> CreateProjectAsync(BaseProject project, Guid subjectId)
        {
            var result = await _projectRepository.CreateProjectAsync(project, subjectId);
            if (result)
            {
                foreach (var topic in project.ListTopics)
                {
                    result |= await _topicRepository.CreateTopicAsync(topic, project.Id);
                }
            }
            return result;
        }

        public async Task<BaseProject> GetProjectDetailAsync(Guid projectId)
        {
            var result = await _projectRepository.GetProjectDetailAsync(projectId);
            if (result != null)
            {
                result.ListTopics = await _topicRepository.GetListTopicsByProjectAsync(projectId);
            }
            return result;
        }

        public async Task<BaseProject> GetProjectDetailAsync(Guid projectId, Guid userId)
        {
            var result = await _projectRepository.GetProjectDetailAsync(projectId);
            if (result != null)
            {
                var topic = await _topicRepository.GetRegisterdTopicAsync(projectId,userId);
                if(result.ListTopics == null)
                    result.ListTopics = new List<Topic>();
                result.ListTopics.Add(topic);
            }
            return result;
        }

        public async Task<List<BaseProject>> GetListProjectCanRegisterAsync(Guid courseId)
        {
            var listProjects = await _projectRepository.GetListProjectCanRegisterAsync(courseId);
            return listProjects;
        }

        public async Task<List<BaseProject>> GetListProjectCanNotRegisterAsync(Guid courseId)
        {
            var listProjects = await _projectRepository.GetListProjectCanNotRegisterAsync(courseId);
            return listProjects;
        }

        public async Task<List<ProjectType>> GetListProjectTypeAsync()
        {
            var listProjectTypes = await _projectRepository.GetListProjectTypeAsync();
            return listProjectTypes;
        }

        public async Task<bool> SaveProjectInformationAsync(BaseProject project)
        {
            var result = await _projectRepository.SaveProjectInformationAsync(project);
            return result;
        }

        public async Task<bool> RemoveTopicAsync(Guid topicId, Guid projectId)
        {
            var result = await _projectRepository.RemoveTopicAsync(topicId, projectId);
            return result;
        }

        public async Task<List<BaseProject>> GetListPraceticeProjectAsync()
        {
            var listProjects = await _projectRepository.GetListPraceticeProjectAsync();
            return listProjects;
        }

        public async Task<bool> IsRegisterProjectAsync(Guid projectId, Guid userId)
        {
            var result = await _projectRepository.IsRegisterProjectAsync(projectId, userId);
            return result;
        }
    }
}
