using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Example.Controller.Config
{
    /// <summary>
    /// Represents the controller for the export and import.
    /// </summary>
    public class Export
    {
        #region Constructor

        /// <summary>
        /// Prevents a default instance of the <see cref="ExportConfiguration"/> class from being created.
        /// </summary>
        private Export()
        {
        }

        #endregion

        #region Static Fields

        private static Export _instance = null;
        private static object _instanceObject = new object();

        #endregion

        #region Instance Method

        /// <summary>
        /// Gets an single static instance of information class.
        /// </summary>
        public static Export Instance
        {
            get
            {
                lock (_instanceObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Export();
                    }

                    return _instance;
                }
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Gets the used field items.
        /// </summary>
        /// <param name="exportIdPathes">The export identifier pathes.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The variables, data fields, and node fields used in the configuration.</returns>
        public Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] GetUsedFieldItems(string exportIdPathes, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // Define used field items to return.
            List<Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem> fieldItemsToReturn = null;

            // Instantiate the list to return as arry.
            fieldItemsToReturn = new List<Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem>();

            // Define messages to return as out parameter.
            List<Development.SDK.Module.Data.Systems.ReportMessage> reportMessages = null;

            // Instantiate the report messages to return as out parameter.
            reportMessages = new List<Development.SDK.Module.Data.Systems.ReportMessage>();

            return fieldItemsToReturn.ToArray();
        }

        #endregion

        #region Export Methods 

        /// <summary>
        /// Prepares the information for export.
        /// </summary>
        /// <param name="moduleConfigParameters">The current module configuration parameters.</param>
        /// <returns>The container with the information which dependencies exist for the configurations.</returns>
        public Development.SDK.Module.Data.Export.ExportContainer[] PrepareExport(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] moduleConfigParameters, out Development.SDK.Module.Data.Systems.ReportMessage[] messages)
        {
            // Set default value for the export messages
            messages = new Development.SDK.Module.Data.Systems.ReportMessage[0];

            // TODO: Insert your prepare export methods here if you have a module configuration.

            return new Development.SDK.Module.Data.Export.ExportContainer[0];
        }

        /// <summary>
        /// Exports the specified export identifier path.
        /// </summary>
        /// <param name="exportIdPath">The export identifier path.</param>
        /// <param name="moduleConfigParameters">The module configuration parameters.</param>
        /// <param name="messages">The messages.</param>
        /// <returns>The configuration to be exported as JSON string</returns>
        public string ExportConfiguration(string exportIdPath, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] moduleConfigParameters, out Development.SDK.Module.Data.Systems.ReportMessage[] messages)
        {
            // Set default value for the export messages
            messages = new Development.SDK.Module.Data.Systems.ReportMessage[0];

            // Define string value for json export
            string jsonExport = string.Empty;

            // TODO: Insert your export methods here if you have a module configuration.

            return jsonExport;
        }

        #endregion

        #region Import Methods

        /// <summary>
        /// Imports the specified export container.
        /// </summary>
        /// <param name="exportContainer">The export container.</param>
        /// <param name="moduleConfigParameters">The module configuration parameters.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        /// <param name="messages">The messages.</param>
        /// <returns><c>true</c> if the import was successful; otherwise <c>false</c></returns>
        public bool Import(Development.SDK.Module.Data.Export.ExportContainer[] exportContainer, ref Development.SDK.Module.Data.Kernel.Module.NodeParameter[] moduleConfigParameters, bool overwrite, out Development.SDK.Module.Data.Systems.ReportMessage[] messages)
        {
            // Set default value for the export messages
            messages = new Development.SDK.Module.Data.Systems.ReportMessage[0];

            // TODO: Insert your import methods here if you have a module configuration.

            return true;
        }

        #endregion
    }
}
