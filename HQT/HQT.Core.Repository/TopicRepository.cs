using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Model;
using HQT.Shared;

namespace HQT.Core.Repository
{
    public class TopicRepository:ITopicRepository
    {
        public async Task<List<Topic>> GetListTopicsAsync()
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_GetList"))
            {
                var listParams  = new Dictionary<string, object>();
                var result = await db.ExecuteReaderAsync(listParams);
                var listTopics = new List<Topic>();
                while (result.Read())
                {
                    var id = result["TopicId"].GetGuid();
                    var title = result["Title"].GetString();
                    var detail = result["Content"].GetString();
                    var topic = new Topic { Id = id, Title = title, Detail = detail };
                    listTopics.Add(topic);
                }
                return listTopics;
            }
        }

        public async Task<bool> CreateTopicAsync(Topic topic, Guid projectId)
        {
            try
            {
                using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_Add"))
                {
                    var listParams = new Dictionary<string, object>
                    {
                        {"TopicId", topic.Id},
                        {nameof(topic.Title), topic.Title},
                        {"Content", topic.Detail},
                        {nameof(projectId), projectId }
                    };
                    var result = await db.ExecuteNonQueryAsync(listParams);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public async Task<List<Topic>> GetListTopicsByProjectAsync(Guid projectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_GetListByProjectId"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(projectId), projectId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listTopics = new List<Topic>();
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();
                    while (next && result.Read())
                    {
                        var id = result["TopicId"].GetGuid();
                        var title = result["Title"].GetString();
                        var detail = result["Content"].GetString();
                        var topic = new Topic { Id = id, Title = title, Detail = detail };
                        listTopics.Add(topic);
                    }
                }
                return listTopics;
            }
        }

        public async Task<List<Topic>> GetListFullTopicsByProjectAsync(Guid projectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_GetFullTopic"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(projectId), projectId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listTopics = new List<Topic>();
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();

                    while (next && result.Read())
                    {
                        var id = result["TopicId"].GetGuid();
                        var title = result["Title"].GetString();
                        var detail = result["Content"].GetString();
                        var topic = new Topic() { Id = id, Title = title, Detail = detail };
                        listTopics.Add(topic);
                    }
                }
                return listTopics;
            }
        }

        public async Task<List<Topic>> GetListNotFullTopicsByProjectAsync(Guid projectId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_GetNotFullTopic"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(projectId), projectId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                var listTopics = new List<Topic>();
                if (result.Read())
                {
                    var count = result.GetInt32(0);
                    var next = result.NextResult();
                    
                    while (next && result.Read())
                    {
                        var id = result["TopicId"].GetGuid();
                        var title = result["Title"].GetString();
                        var detail = result["Content"].GetString();
                        var topic = new Topic() { Id = id, Title = title, Detail = detail };
                        listTopics.Add(topic);
                    }
                }
                return listTopics;
            }
        }

        public async Task<bool> CreateGroupAsync(Guid groupId, Guid studentId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Group_Student_Add"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(groupId), groupId},
                    {nameof(studentId), studentId }
                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<bool> DeleteGroupAsync(Guid groupId, Guid studentId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Group_Student_Delete"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(groupId), groupId},
                    {nameof(studentId), studentId }
                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<Topic> GetTopicDetailAsync(Guid topicId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Topic_GetDetail"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {nameof(topicId), topicId}
                };
                var result = await db.ExecuteReaderAsync(listParams);
                if (result.Read())
                {
                    var id = result["TopicId"].GetGuid();
                    var title = result["Title"].GetString();
                    var detail = result["Content"].GetString();
                    var topic = new Topic() { Id = id, Title = title, Detail = detail };
                    return topic;
                }
                return null;
            }
        }

        public async Task<bool> CreateGroupAsync(Group group)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Group_Add"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {"Groupid", group.Id},
                    {nameof(group.GroupName), group.GroupName },
                    {"leader", group.Leader.Id },
                    {"topicId", group.TopicId },
                    {"projectId", group.ProjectId },
                    {"Capacity", group.Capacity }

                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        

        public async Task<bool> AddMemberIntoGroupAsync(Guid groupId, Guid userId)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Group_Student_Add"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {"groupId", groupId},
                    {"studentId", userId }

                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }

        public async Task<bool> RegisterTopicAsync(Group @group)
        {
            using (var db = DataAccessFactory.CreateDataAccess("sp_Student_Topic_Project_Add"))
            {
                var listParams = new Dictionary<string, object>()
                {
                    {"studentId", group.Leader.Id},
                    {"topicId", group.TopicId },
                    {"projectId", group.ProjectId }

                };
                var result = await db.ExecuteNonQueryAsync(listParams);
                return result > 0;
            }
        }
    }
}
