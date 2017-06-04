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
    }
}
