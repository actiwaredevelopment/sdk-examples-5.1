using System;

namespace Module.Example
{
    /// <summary>
    /// Represensts core module.
    /// </summary>
    public class Module : Development.SDK.Module.Interfaces.Kernel.Module.IModule
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Module.Systems.Module"/> class.
        /// </summary>
        public Module()
        {
        }

        #endregion

        #region Metadata

        /// <summary>
        /// Returns the SDK version needed to run the module.
        /// </summary>
        public Version MinimumSdkVersion
        {
            get { return new Version("1.0.0"); }
        }

        /// <summary>
        /// Returns the module identifier.
        /// </summary>
        public System.Guid Id
        {
            get { return new Guid("{3D6C823D-E269-421C-9302-322D4C4F4925}"); }
        }

        /// <summary>
        /// Returns the name for the license check. This value is optional and only required by the software vendor.
        /// </summary>
        public string LicenceName
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Returns the version for the license check. This value is optional and only required by the software vendor.
        /// </summary>
        public string LicenceVersion
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Returns the module name.
        /// </summary>
        public string Name
        {
            get { return "Example"; }
        }

        /// <summary>
        /// Returns the display name for the module.
        /// </summary>
        public string DisplayName
        {
            get { return "Module Example"; }
        }

        /// <summary>
        /// Returns the description for the module.
        /// </summary>
        public string Description
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// Returns the  icon for the module.
        /// </summary>
        /// <remarks>The icon must contain the following sizes: 16x16, 24x24, 32x32 and 64x64</remarks>
        public System.Drawing.Icon Icon
        {
            get { return null; }
        }

        /// <summary>
        /// Return the current version of the module.
        /// </summary>
        public System.Version Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; }
        }

        #endregion

        #region Node informations

        /// <summary>
        /// Returns all action nodes the implementing module provides.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.IActionNode[] ActionNodes
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IActionNode[]
                {
                    new ActionNode.ExampleNode()
                };
            }
        }

        /// <summary>
        /// Returns all content adapter the implementing module provides.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.IContentAdapter[] ContentAdapters
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IContentAdapter[]
                {
                
                };
            }
        }

        /// <summary>
        ///Returns all tile actions the implementing module provides.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.ITileAction[] TileActions
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.ITileAction[]
                {
                  
                };
            }
        }

        /// <summary>
        /// Returns all client nodes the implementing module provides.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.IClientNode[] ClientNodes
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IClientNode[]
                {
                   
                };
            }
        }

        #endregion

        #region Field type information

        /// <summary>
        /// Returns all field types provided by the module.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.IFieldType[] FieldTypes
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IFieldType[]
                {

                };
            }
        }

        #endregion

        #region Desktop extensions information

        /// <summary>
        /// Returns all desktop extensions provided by the module.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.IDesktopExtension[] DesktopExtensions
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IDesktopExtension[]
                {
                  
                };
            }
        }

        #endregion

        #region Repositories information

        /// <summary>
        /// Returns all repositories provided by the module.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.IRepository[] Repositories
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IRepository[]
                {
                    
                };
            }
        }

        #endregion

        #region Link Providers Information

        /// <summary>
        /// Returns all link providers provided by the module.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.ILinkProvider[] LinkProviders
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.ILinkProvider[]
                {

                };
            }
        }

        #endregion

        #region Search Provider Information

        /// <summary>
        /// Returns all search providers provided by the module.
        /// </summary>
        public Development.SDK.Module.Interfaces.Kernel.Module.ISearchProvider[] SearchProviders
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.ISearchProvider[]
                {
                   
                };
            }
        }

        #endregion

        #region Initialize Methods

        /// <summary>
        /// This method is called once on designer application startup and once every time modules where uploaded to the service.
        /// </summary>
        /// <param name="isServiceCall"><c>true</c> if the service calles this function, otherwise (the Designer calles it) <c>false</c>.</param>
        /// <remarks>You need to check, if you already have installed your components you want to install here.</remarks>
        public void InstallNeededPackages(Development.SDK.Module.Controller.Helper.InstallHelper installHelper)
        {

        }

        /// <summary>
        /// Initializes ui elements for designer application.
        /// </summary>
        /// <remarks>This method is only called at application start.</remarks>
        public void InitializeUi()
        {
            // Initialize elo admin console
            
        }

        /// <summary>
        /// Initializes system options for module. At this time the module must load all needed system options.
        /// </summary>
        /// <param name="connectionString">Connection string for the database.</param>
        /// <remarks>This method is called when system options were loaded.</remarks>
        public void InitializeSystemOptions(string connectionString)
        {

        }

        /// <summary>
        /// Initializes project configurations for module. At this time the module must load all needed configurations.
        /// </summary>
        /// <param name="installHelper">The install helper.</param>
        /// <remarks>
        /// This method is called when a project is re-/loaded.
        /// </remarks>
        public void InitializeProjectConfig(Development.SDK.Module.Controller.Helper.InstallHelper installHelper)
        {
           
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
        /// Called when a new project was loaded.
        /// </summary>
        /// <remarks>
        ///  Called directly after <see cref="Development.SDK.Module.Interfaces.Kernel.Module.IModule.InitializeProjectConfig"/>
        ///  </remarks>
        public void RefreshViewModel()
        {
            // Initialize general view model
            
        }

        public Development.SDK.Module.Interfaces.Kernel.Module.IConfigItem[] GetConfigParts()
        {
            return new Development.SDK.Module.Interfaces.Kernel.Module.IConfigItem[0];
        }

        #endregion

        #region Inspect Methods

        /// <summary>
        /// Inspects the module configuration.
        /// </summary>
        /// <param name="fieldItems">The used field items.</param>
        /// <param name="errors">The errors that was occured by inspect configuration.</param>
        public void Inspect(out Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] fieldItems, out Development.SDK.Module.Data.Systems.ModuleException[] errors)
        {
            // TODO : Inspect
            fieldItems = new Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[0];
            errors = new Development.SDK.Module.Data.Systems.ModuleException[0];
        }

        public void Inspect(out Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[] repositoryItems, out Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] fieldItems, out Development.SDK.Module.Data.Systems.ModuleException[] errors)
        {
            repositoryItems = new Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[0];
            this.Inspect(out fieldItems, out errors);
        }

        #endregion

        #region Config part executation

        /// <summary>
        /// Executes the module configuration part. Not implemented.
        /// </summary>
        /// <param name="configPartId">The configuration part identifier.</param>
        /// <param name="fieldItems">The field items.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>Always <c>null</c>.</returns>
        public object ExecuteModuleConfigPart(string configPartId, Development.SDK.Module.Controller.Helper.ScriptHelper helper, Development.SDK.Module.Interfaces.Kernel.Module.ISmallFieldItem[] fieldItems, params object[] parameters)
        {
            return null;
        }

        #endregion

        #region GUI Backstage Methods

        /// <summary>
        /// Gets a value indicating whether this module has a global configuration.
        /// </summary>
        /// <value><c>true</c> if this module has a global configuration; otherwise, <c>false</c>.</value>
        public bool HasGlobalConfiguration
        {
            get { return false; }
        }

        /// <summary>
        /// Called when the designer wants to display a general module configuration control. This is only called if the designer hasn't already an unsaved config control in its cache.
        /// </summary>
        /// <returns>The control to be displayed. <c>null</c> if the node has no configuration.</returns>
        public System.Windows.Controls.Control LoadGlobalConfig(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            return null;
        }

        /// <summary>
        /// Called when the designer wants to save the general module configuration.
        /// </summary>
        /// <param name="configControl">The configuration control given returned from <see cref="Development.SDK.Module.Interfaces.Kernel.Module.IModule.LoadConfig"/>.</param>
        public void SaveGlobalConfig(System.Windows.Controls.Control configControl, out Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            // set default parameter value
            parameters = new Development.SDK.Module.Data.Kernel.Module.NodeParameter[0];
        }

        #endregion

        #region External packages

        /// <summary>
        /// Imports an external package.
        /// </summary>
        /// <param name="package">The package to import.</param>
        /// <returns><c>true</c> if the package was imported, otherwise <c>false</c>.</returns>
        public bool ImportExternalPackage(Development.SDK.Module.Controller.Helper.InstallHelper installHelper, object package)
        {
            return true;
        }

        #endregion

        #region Service Upload Methods

        /// <summary>
        /// Called by service when it wants to remove a configuration for a specific project.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        public void ClearServiceConfig(int projectId)
        {

        }

        /// <summary>
        /// Called by the designer when it wants to upload configurations to the service.
        /// </summary>
        /// <returns>A string that is given to the service.</returns>
        public string ExportConfig()
        {
            return string.Empty;
        }

        /// <summary>
        /// Called by the service, when it wants to import a node configuration.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="config">The configuration.</param>
        /// <returns>
        ///   <c>true</c> if the import was successful, otherwise <c>false</c>.
        /// </returns>
        public bool ImportConfig(int projectId, string config)
        {
            return true;
        }

        #endregion

        #region Service Download Methods

        /// <summary>
        /// Called by the service when it was requested to upload the current configuration to the designer.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>
        /// A string that is given to the designer.
        /// </returns>
        public string ExportServiceConfig(int projectId)
        {
            return string.Empty;
        }

        /// <summary>
        /// Called by the designer, when it wants to import a node configuration from the service.
        /// </summary>
        /// <param name="projectName">Name of the project that contains the config.</param>
        /// <param name="config">The configuration generated by <see cref="Development.SDK.Module.Interfaces.Kernel.Module.IModule.ExportServiceConfig"/>.</param>
        /// <returns></returns>
        public bool ImportServiceConfig(string config)
        {
            return false;
        }

        #endregion

        #region Authentification Providers Information

        /// <summary>
        /// Returns all authentication providers the implementing module provides.
        /// </summary>

        public Development.SDK.Module.Interfaces.Kernel.Module.IAuthenticationProvider[] AuthentificationProviders
        {
            get
            {
                return new Development.SDK.Module.Interfaces.Kernel.Module.IAuthenticationProvider[]
                {

                };
            }
        }

        #endregion

        #region Export Methods

        /// <summary>
        /// Gets the used repository items.
        /// </summary>
        /// <param name="exportIdPath">The export identifier path.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The repository items that was referenced in the configuration.</returns>
        public Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[] GetUsedRepositoryItems(string exportIdPath, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            return new Development.SDK.Module.Interfaces.Kernel.Module.ISmallRepositoryItem[0];
        }

        /// <summary>
        /// Exports the specified export identifier path.
        /// </summary>
        /// <param name="exportIdPath">The export identifier path.</param>
        /// <param name="moduleConfigParameters">The module configuration parameters.</param>
        /// <param name="messages">The messages.</param>
        /// <returns>The configuration to be exported as JSON string</returns>
        public string Export(string exportIdPath, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] moduleConfigParameters, out Development.SDK.Module.Data.Systems.ReportMessage[] messages)
        {
            return Controller.Config.Export.Instance.ExportConfiguration(exportIdPath, moduleConfigParameters, out messages);
        }

        /// <summary>
        /// Prepares the information for export.
        /// </summary>
        /// <param name="moduleConfigParameters">The current module configuration parameters.</param>
        /// <returns>The container with the information which dependencies exist for the configurations.</returns>
        public Development.SDK.Module.Data.Export.ExportContainer[] PrepareExport(Development.SDK.Module.Data.Kernel.Module.NodeParameter[] moduleConfigParameters, out Development.SDK.Module.Data.Systems.ReportMessage[] messages)
        {
            return Controller.Config.Export.Instance.PrepareExport(moduleConfigParameters, out messages);
        }

        #endregion

        #region Get used Field Items Method

        /// <summary>
        /// Gets the used field items.
        /// </summary>
        /// <param name="exportIdPathes">The export identifier pathes.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The variables, data fields, and node fields used in the configuration.</returns>
        public Development.SDK.Module.Interfaces.Kernel.Module.IFieldItem[] GetUsedFieldItems(string exportIdPathes, Development.SDK.Module.Data.Kernel.Module.NodeParameter[] parameters)
        {
            return Controller.Config.Export.Instance.GetUsedFieldItems(exportIdPathes, parameters);
        }

        #endregion

        #region Import

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
            return Controller.Config.Export.Instance.Import(exportContainer, ref moduleConfigParameters, overwrite, out messages);
        }

        #endregion

        #region Documentation

        /// <summary>
        /// Generates the module backstage documentation.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="showPasswords">if set to true, show passwords in the documentation.</param>
        public void GenerateModuleBackstageDocumentation(Development.SDK.Module.Controller.Helper.DocumentationHelper helper, string[] filter, bool showPasswords)
        {

        }

        /// <summary>
        /// Generates the module configuration documentation.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="showPasswords">if set to true, show passwords in the documentation.</param>
        public void GenerateModuleConfigDocumentation(Development.SDK.Module.Controller.Helper.DocumentationHelper helper, string[] filter, bool showPasswords)
        {
            
        }

        /// <summary>
        /// Generates the module main content documentation.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="showPasswords">if set to true, show passwords in the documentation.</param>
        public void GenerateModuleMainContentDocumentation(Development.SDK.Module.Controller.Helper.DocumentationHelper helper, string[] filter, bool showPasswords)
        {

        }

        #endregion
    }
}
