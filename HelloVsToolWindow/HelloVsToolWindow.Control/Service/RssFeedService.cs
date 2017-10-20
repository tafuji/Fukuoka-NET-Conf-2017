using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HelloVsToolWindow.Control.Service
{
    internal class RssFeedService
    {
        /// <summary>
        /// Feed endpoint uri
        /// </summary>
        private string Endpoint;

        /// <summary>
        /// Feed items
        /// </summary>
        public Rss Feed { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public RssFeedService(string endpoint)
        {
            this.Endpoint = endpoint;
        }

        /// <summary>
        /// Update feeds
        /// </summary>
        /// <returns>Task</returns>
        public async Task<Rss> Update()
        {
            var client = new HttpClient();
            Rss result;

            using (var reader = new StringReader(await client.GetStringAsync(Endpoint).ConfigureAwait(false)))
            {
                var desirializer = new XmlSerializer(typeof(Rss));
                result = desirializer.Deserialize(reader) as Rss;
            }

            if (result == null || result.Channel.LastBuildDate.CompareTo(this.Feed.Channel.LastBuildDate) <= 0)
            {
                return null;
            }
            return result;
        }
    }
}
