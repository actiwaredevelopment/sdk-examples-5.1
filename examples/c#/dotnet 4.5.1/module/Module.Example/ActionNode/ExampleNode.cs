using System;

namespace Module.Example.ActionNode
{
    public class ExampleNode : Development.SDK.Module.Data.GUI.Binding.BaseViewModel, Development.SDK.Module.Interfaces.Kernel.Module.IActionNode
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleNode"/> class.
        /// </summary>
        public ExampleNode()
        {

        }

        #endregion

        #region Fields

        private string _description = null;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the identifier of the node.
        /// </summary>
        public Guid Id
        {
            get { return new Guid("{A8971EC4-3CCC-45D3-A010-334D94B01FA5}"); }
        }

        /// <summary>
        /// Gets the icon of the node.
        /// </summary>
        public System.Drawing.Icon Icon
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the name of the licence.
        /// </summary>
        public string LicenceName
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Gets the licence version.
        /// </summary>
        public string LicenceVersion
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Gets the node color for node
        /// </summary>
        public Development.SDK.Module.Data.GUI.Node.Color NodeColor
        {
            get { return new Development.SDK.Module.Data.GUI.Node.Color("#FFFFFFFF", "#FF0072C6;#FF0083C1", "#FF1A80CC", true); }
        }

        /// <summary>
        /// Gets the name of the node.
        /// </summary>
        public string Name
        {
            get { return "ExampleActionNode"; }
        }

        /// <summary>
        /// Gets the display name of the node.
        /// </summary>
        public string DisplayName
        {
            get { return "My Example Action Node"; }
        }

        /// <summary>
        /// Gets the description text of the node.
        /// </summary>
        public string Description
        {
            get
            {
                if (this._description == null)
                {
                    return "";
                }
                else
                {
                    return _description;
                }
            }
            private set { SetField(ref _description, value); }
        }

        /// <summary>
        /// Gets the configuration key.
        /// </summary>
        public string ConfigurationKey
        {
            get { return "Module.Example.ActioNode.ExamplNode"; }
        }

        /// <summary>
        /// Gets the category name for the node.
        /// </summary>
        public string CategoryName
        {
            get { return "Example"; }
        }

        /// <summary>
        /// Gets the type of the configuration control.
        /// </summary>
        public Development.SDK.Module.Enums.Systems.ConfigControlType ConfigControlType
        {
            get { return Development.SDK.Module.Enums.Systems.ConfigControlType.ParameterControl; }
        }

        /// <summary>
        /// Gets the supported process types.
        /// </summary>
        public Development.SDK.Module.Enums.Systems.ProcessType SupportedProcessTypes
        {
            get { return Development.SDK.Module.Enums.Systems.ProcessType.Logic | Development.SDK.Module.Enums.Systems.ProcessType.Content; }
        }

        /// <summary>
        /// Gets the supported connection ports of the node.
        /// </summary>
        /// <remarks>This porperty can be return null, if node supports only one connection port.</remarks>
        public Development.SDK.Module.Data.Kernel.Node.ConnectionPort[] ConnectionPorts
        {
            get
            {
                // Define connection port
                Development.SDK.Module.Data.Kernel.Node.ConnectionPort port = null;

                // Create new connection port
                port = new Development.SDK.Module.Data.Kernel.Node.ConnectionPort("Endpoint",
                                                                                  "Its the endpoint to the next node.",
                                                                                  "#FF1CBC33");

                // Return useable connection ports
                return new Development.SDK.Module.Data.Kernel.Node.ConnectionPort[] { port };
            }
        }

        /// <summary>
        /// Gets the shape that must be displayed for the node.
        /// </summary>
        public Development.SDK.Module.Enums.Styles.NodeShape NodeShape
        {
            get { return Development.SDK.Module.Enums.Styles.NodeShape.Rectangle; }
        }

        /// <summary>
        /// Gets the needed parameters for the node.
        /// </summary>
        /// <remarks>This property can be return null, if the node has an own configuration control.</remarks>
        public Development.SDK.Module.Data.Kernel.Module.NodeParameter[] Parameters
        {
            get
            {
                return new Development.SDK.Module.Data.Kernel.Module.NodeParameter[]
                {
                    new Development.SDK.Module.Data.Kernel.Module.NodeParameter()
                    {
                        Name = "Parameter1",
                        Label = "Parameter 1"
                    },
                    new Development.SDK.Module.Data.Kernel.Module.NodeParameter()
                    {
                        Name = "Parameter2",
                        Label = "Parameter 2"
                    },
                };
            }
        }

        #endregion

        #region Execution Methods

        /// <summary>
        /// Performs node rollback actions. This method was called if a process occures an error.
        /// </summary>
        /// <param name="inputContainer">The process container from caller node.</param>
        /// <param name="outputContainer">The process container from node that was returned by execution.</param>
        /// <param name="helper">The active <see cref="Development.SDK.Module.Controller.Helper.ScriptHelper"/> script helper controller.</param>
        public Development.SDK.Module.Controller.Container.ProcessContainer Rollback(Development.SDK.Module.Controller.Container.ProcessContainer inputContainer, Development.SDK.Module.Controller.Container.ProcessContainer outputContainer, Development.SDK.Module.Controller.Helper.ScriptHelper helper)
        {
            return inputContainer;
        }

        /// <summary>
        /// Performs node runtime actions.
        /// </summary>
        /// <param name="container">The outgoing process container from caller node.</param>
        /// <param name="helper">The active <see cref="Development.SDK.Module.Controller.Helper.ScriptHelper"/> script helper controller.</param>
        /// <returns>Outgoing <c>Development.SDK.Module.Controller.Container.ProcessContainer</c> of the node.</returns>
        public Development.SDK.Module.Controller.Container.ProcessContainer Execute(Development.SDK.Module.Controller.Container.ProcessContainer container, Development.SDK.Module.Controller.Helper.ScriptHelper helper)
        {
            return Controller.ActionNode.ExampleNode.ExecuteActionNode.Instance.Execute(container, helper);
        }

        /// <summary>
        /// Performs node runtime actions in test mode.
        /// </summary>
        /// <param name="container">The process container with test data.</param>
        /// <param name="helper">The active <see cref="Development.SDK.Module.Controller.Helper.ScriptHelper"/> script helper controller.</param>
        /// <returns>Outgoing <c>Development.SDK.Module.Controller.Container.ProcessContainer</c> of the node.</returns>
        public Development.SDK.Module.Controller.Container.ProcessContainer TestExecute(Development.SDK.Module.Controller.Container.ProcessContainer container, Development.SDK.Module.Controller.Helper.ScriptHelper helper)
        {
            return Controller.ActionNode.ExampleNode.ExecuteActionNode.Instance.Execute(container, helper);
        }

        #endregion

        #region GUI Methods

        /// <summary>
        /// Gets the user language entries.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The language entries generated by the user.</returns>
        public Development.SDK.Module.Data.GUI.Module.LanguageEntry[] GetUserLanguageEntries(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            return new Development.SDK.Module.Data.GUI.Module.LanguageEntry[0];
        }

        /// <summary>
        /// Is called if the module configuration was changed.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to load the config for.</param>
        /// <param name="configControl">The configuration control given returned from <see cref="Development.SDK.Module.Interfaces.Kernel.Module.IBaseNode.LoadConfig"/>.</param>
        /// <param name="parameters">The saved node parameters.</param>
        public void RefreshConfig(Guid processId, Guid processNodeId, System.Windows.Controls.Control configControl, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters = null)
        {

        }

        /// <summary>
        /// Called when the designer wants to display a configuration control. This is only called if the designer hasn't already an unsaved config control in its cache.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to load the config for.</param>
        /// <returns>The control to be displayed. <c>null</c> if the node has no configuration.</returns>
        public System.Windows.Controls.Control LoadConfig(Guid processId, Guid processNodeId, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // TODO: Load the user control if you need it for the configuration
            return null;
        }

        /// <summary>
        /// Called when the designer wants to save the configuration.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to save the config for.</param>
        /// <param name="configControl">The configuration control given returned from <see cref="Development.SDK.Module.Interfaces.Kernel.Module.IBaseNode.LoadConfig"/>.</param>
        public void SaveConfig(Guid processId, Guid processNodeId, System.Windows.Controls.Control configControl, out Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // TODO: Use the user control to save the configuration
            parameters = new Development.SDK.Module.Data.Kernel.Module.NodeParameter[0];
        }

        /// <summary>
        /// Called when the designer wants to create a snapshot of the current config control.
        /// </summary>
        /// <param name="userControl">The control to create the snapshot from.</param>
        /// <returns>The object with that the designer can revert to the snapshoted state.</returns>
        public object CreateConfigSnapshot(System.Windows.Controls.Control userControl)
        {
            // TODO: Use the user control to create a snapshot of the configuration
            return null;
        }

        /// <summary>
        /// Called when the designer wants to revert a user control to a given snapshot.
        /// </summary>
        /// <param name="userControl">The user control to revert the snapshot to.</param>
        /// <param name="snapshot">The snapshot to revert to.</param>
        public void RevertToConfigSnapshot(System.Windows.Controls.Control userControl, object snapshot)
        {
            if (userControl != null)
            {
                userControl.DataContext = snapshot;
            }
        }

        /// <summary>
        /// Called when the designer deletes a node.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to delete the config for.</param>
        /// <returns><c>true</c> if the config was deleted, otherwise <c>false</c>.</returns>
        public bool DeleteConfig(Guid processId, Guid processNodeId)
        {
            return false;
        }

        /// <summary>
        /// Validates the configuration.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to delete the config for.</param>
        /// <param name="configControl">The configuration control given returned from <see cref="Development.SDK.Module.Interfaces.Kernel.Module.IBaseNode.LoadConfig"/>.</param>
        /// <returns><c>true</c> if the config is valid, otherwise <c>false</c>.</returns>
        public bool ValidateConfig(Guid processId, Guid processNodeId, System.Windows.Controls.Control configControl)
        {
            // TODO: Use the user control to validate the configuration
            return true;
        }

        /// <summary>
        /// Validates the configuration.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to delete the config for.</param>
        /// <param name="parameters">The parameters with setted value from user.</param>
        /// <returns><c>true</c> if the config is valid, otherwise <c>false</c>.</returns>
        public bool ValidateConfig(Guid processId, Guid processNodeId, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // TODO: Validate the configuration
            return true;
        }

        #endregion

        #region Inspect Methods

        /// <summary>
        /// Inspects the node configuration.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to load the config for.</param>
        /// <param name="parameters">The configuration parameters.</param>
        /// <param name="fieldItems">The used field items.</param>
        /// <param name="errors">The errors that was occured by inspect configuration.</param>
        public void Inspect(Guid processId, Guid processNodeId, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters, out Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] fieldItems, out Development.SDK.Module.Data.Systems.ModuleException[] errors)
        {
            // Set default values for output parameter
            fieldItems = new Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[0];
            errors = new Development.SDK.Module.Data.Systems.ModuleException[0];

            // Inspect configuration
            Controller.ActionNode.ExampleNode.ConfigActionNode.Instance.Inspect(processId, processNodeId, parameters, out fieldItems, out errors);
        }

        /// <summary>
        /// Inspects the node configuration.
        /// </summary>
        /// <param name="processId">Id of the process that contains the node.</param>
        /// <param name="processNodeId">The id of the node to load the config for.</param>
        /// <param name="parameters">The configuration parameters.</param>
        /// <param name="repositoryItems">The used repository items.</param>
        /// <param name="fieldItems">The used field items.</param>
        /// <param name="errors">The errors that was occured by inspect configuration.</param>
        public void Inspect(Guid processId, Guid processNodeId, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters, out Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[] repositoryItems, out Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] fieldItems, out Development.SDK.Module.Data.Systems.ModuleException[] errors)
        {
            repositoryItems = new Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[0];

            this.Inspect(processId, processNodeId, parameters, out fieldItems, out errors);
        }

        /// <summary>
        /// Gets the used field items.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[].</returns>
        public Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] GetUsedFieldItems(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            return Controller.ActionNode.ExampleNode.ConfigActionNode.Instance.GetUsedFieldItems(parameters);
        }

        /// <summary>
        /// Gets the used repository items.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The used guids</returns>
        public Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[] GetUsedRepositoryItems(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            return new Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[0];
        }
        #endregion

        #region Export Methods

        /// <summary>
        /// Prepares the export.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <param name="dependencies">The dependencies.</param>
        public void PrepareExport(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters, out string[] dependencies)
        {
            Controller.ActionNode.ExampleNode.ConfigActionNode.Instance.PrepareExport(parameters, out dependencies);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Called when the designer wants to create a new instance of the implementing class.
        /// </summary>
        /// <returns>A new instance of the implementing class.</returns>
        public Development.SDK.Module.Interfaces.Kernel.Module.IActionNode CreateNewInstance()
        {
            return new ExampleNode();
        }

        /// <summary>
        /// Gets the node fields.
        /// </summary>
        /// <param name="processId">The process identifier.</param>
        /// <param name="processNodeId">The process node identifier.</param>
        /// <returns></returns>
        public Development.SDK.Module.Interfaces.GUI.Module.IFieldItem[] GetNodeFields(Guid processId, Guid processNodeId, System.Windows.Controls.Control configControl, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // Define node field array
            Development.SDK.Module.Interfaces.GUI.Module.IFieldItem[] nodeFields = null;

            // Get parent node fields
            return nodeFields;
        }

        #endregion

        #region Documentation

        /// <summary>
        /// Generates the documentation.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="showPasswords">if set to <c>true</c> show passwords in the documentation.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="processId">The process identifier.</param>
        /// <param name="processNodeId">The process node identifier.</param>
        /// <param name="parameters">The parameters.</param>
        public void GenerateDocumentation(Development.SDK.Module.Controller.Helper.DocumentationHelper helper, bool showPasswords, string[] filter, Guid processId, Guid processNodeId, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // TODO: Add documentation methods here
        }

        #endregion
    }
}
