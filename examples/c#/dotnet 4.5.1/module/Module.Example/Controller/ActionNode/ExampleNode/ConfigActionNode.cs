using System;
using System.Collections.Generic;

namespace Module.Example.Controller.ActionNode.ExampleNode
{
    public class ConfigActionNode
    {
        #region Constructor

        /// <summary>
        /// Prevents a default instance of the <see cref="ConfigActionNode"/> class from being created.
        /// </summary>
        private ConfigActionNode()
        {
        }

        #endregion

        #region Static Fields

        private static ConfigActionNode _instance = null;
        private static object _instanceObject = new object();

        #endregion

        #region Instance Method

        /// <summary>
        /// Gets an single static instance of information class.
        /// </summary>
        public static ConfigActionNode Instance
        {
            get
            {
                lock (_instanceObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigActionNode();
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
        public Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] GetUsedFieldItems(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // Define used field items to return.
            List<Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem> fieldItemsToReturn = null;

            // Instantiate the list to return as arry.
            fieldItemsToReturn = new List<Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem>();

            return fieldItemsToReturn.ToArray();
        }

        #endregion

        #region Inspect Methods

        /// <summary>
        /// Inspects the node configuration.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to load the config for.</param>
        /// <param name="fieldItems">The used field items.</param>
        /// <param name="errors">The errors that was occured by inspect configuration.</param>
        public void Inspect(Guid processId, Guid processNodeId, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters, out Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] fieldItems, out Development.SDK.Module.Data.Systems.ModuleException[] errors)
        {
            // Set default value for the field items and errors
            fieldItems = new Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[0];
            errors = new Development.SDK.Module.Data.Systems.ModuleException[0];

            // TODO: Insert your inspect methods here
        }

        #endregion

        #region Export Methods 

        /// <summary>
        /// Prepares the information for export.
        /// </summary>
        /// <param name="parameters">The current configuration parameters.</param>
        /// <param name="dependencies">Returns the dependencies for this configuration</param>
        /// <returns>The container with the information which dependencies exist for the configurations.</returns>
        public Development.SDK.Module.Data.Export.ExportContainer[] PrepareExport(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters, out string[] dependencies)
        {
            // Set default value for the dependencies
            dependencies = new string[0];

            // TODO: Insert your prepare export methods here if you have a module configuration.

            return new Development.SDK.Module.Data.Export.ExportContainer[0];
        }

        #endregion

    }
}
