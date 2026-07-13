using System.Text.Json.Serialization;

namespace Internuntius.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        #region PROPERTIES

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName( "Name" )]
        public string Name
        {
            get;
            init;
        } = null!;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName( "Description" )]
        public string? Description
        {
            get;
            init;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("Groups")]
        public IEnumerable<string> Groups
        {
            get;
            init;
        } = Enumerable.Empty<string>();

        #endregion


        /// <summary>
        /// 
        /// </summary>
        public User()
        { 
        }
    }
}
