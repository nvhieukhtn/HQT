using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Service
{
    public interface ITopicService
    {
        Task<List<Topic>> GetListTopicsAsync();
        Task<List<Topic>> GetListFullTopicsByProjectAsync(Guid projectId);
        Task<List<Topic>> GetListNotFullTopicsByProjectAsync(Guid projectId);
        Task<bool> CreateGroupAsync(Guid groupId, Guid studentId);
        Task<bool> DeleteGroupAsync(Guid groupId, Guid studentId);
        Task<bool> CreateTopicAsync(Topic topic, Guid projectId);
        Task<Topic> GetTopicDetailAsync(Guid topicId);
        Task<bool> CreateGroupAsync(Group group);
        Task<bool> RegisterTopicAsync(Group group);
    }
}
