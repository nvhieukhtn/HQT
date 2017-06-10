using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Model;

namespace HQT.Core.Interface.Repository
{
    public interface ITopicRepository
    {
        Task<List<Topic>> GetListTopicsAsync();
        Task<bool> CreateTopicAsync(Topic topic, Guid projectId);
        Task<List<Topic>> GetListTopicsByProjectAsync(Guid projectId);
        Task<List<Topic>> GetListFullTopicsByProjectAsync(Guid projectId);
        Task<List<Topic>> GetListNotFullTopicsByProjectAsync(Guid projectId);
        Task<bool> CreateGroupAsync(Guid groupId, Guid studentId);
        Task<bool> DeleteGroupAsync(Guid groupId, Guid studentId);
        Task<Topic> GetTopicDetailAsync(Guid topicId);
        Task<bool> CreateGroupAsync(Group group);
        Task<bool> AddMemberIntoGroupAsync(Guid groupId, Guid userId);
        Task<bool> RegisterTopicAsync(Group group);
    }
}
