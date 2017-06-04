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

        public async Task<bool> DeleteProjectAsync(Guid projectId, Guid subjectId)
        {
            var result = await _projectRepository.DeleteProjectAsync(projectId, subjectId);
            return result;
        }
    }
}
