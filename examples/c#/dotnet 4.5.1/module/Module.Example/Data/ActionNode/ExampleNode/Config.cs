using Newtonsoft.Json;

namespace Module.Example.Data.ActionNode.ExampleNode
{
    public class Config
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Config"/> class.
        /// </summary>
        public Config()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// This property is only an example and does not reflect any productive attitude.
        /// </summary>
        /// <remarks>
        /// When creating configuration elements, make sure that they can be saved as JSON objects. 
        /// This ensures that these settings can also be read in for later versions of the product.
        /// </remarks>
        [JsonProperty("storage_path")]
        public string StoragePath { get; set; }

        #endregion
    }
}
