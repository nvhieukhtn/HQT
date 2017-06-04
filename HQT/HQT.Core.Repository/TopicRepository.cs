using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQT.Core.Interface.Repository;
using HQT.Core.Interface.Service;
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
                    var topic = new Topic(){Id = id, Title =  title};
                    listTopics.Add(topic);
                }
                return listTopics;
            }
        }
    }
}
