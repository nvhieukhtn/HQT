using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Interface.Service;
using HQT.Core.Model;

namespace HQT.Core.Service
{
    public class TopicService:ITopicService
    {
        private readonly ITopicRepository _topicRepository;
        public TopicService(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }
        public async Task<List<Topic>> GetListTopicsAsync()
        {
            var listTopics = await _topicRepository.GetListTopicsAsync();
            return listTopics;
        }

        public async Task<List<Topic>> GetListFullTopicsByProjectAsync(Guid projectId)
        {
            var listTopics = await _topicRepository.GetListFullTopicsByProjectAsync(projectId);
            return listTopics;
        }

        public async Task<List<Topic>> GetListNotFullTopicsByProjectAsync(Guid projectId)
        {
            var listTopics = await _topicRepository.GetListNotFullTopicsByProjectAsync(projectId);
            return listTopics;
        }

        public async Task<bool> CreateGroupAsync(Guid groupId, Guid studentId)
        {
            var result = await _topicRepository.CreateGroupAsync(groupId, studentId);
            return result;
        }

        public async Task<bool> DeleteGroupAsync(Guid groupId, Guid studentId)
        {
            var result = await _topicRepository.DeleteGroupAsync(groupId, studentId);
            return result;
        }

        public async Task<bool> CreateTopicAsync(Topic topic, Guid projectId)
        {
            var result = await _topicRepository.CreateTopicAsync(topic, projectId);
            return result;
        }

        public async Task<Topic> GetTopicDetailAsync(Guid topicId)
        {
            var result = await _topicRepository.GetTopicDetailAsync(topicId);
            return result;
        }

        public async Task<bool> CreateGroupAsync(Group group)
        {
            var result = await _topicRepository.CreateGroupAsync(group);
            if (result)
            {
                foreach (var member in group.Members)
                {
                    result |= await _topicRepository.AddMemberIntoGroupAsync(group.Id, member.Id);
                }
            }
            return result;
        }

        public async Task<bool> RegisterTopicAsync(Group @group)
        {
            var result = await _topicRepository.RegisterTopicAsync(group);
            return result;
        }
    }
}
