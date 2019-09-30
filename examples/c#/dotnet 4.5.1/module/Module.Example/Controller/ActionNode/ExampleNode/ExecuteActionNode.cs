namespace Module.Example.Controller.ActionNode.ExampleNode
{
    public class ExecuteActionNode
    {
        #region Constructor

        /// <summary>
        /// Prevents a default instance of the <see cref="ExecuteActionNode"/> class from being created.
        /// </summary>
        private ExecuteActionNode()
        {
        }

        #endregion

        #region Static Fields

        private static ExecuteActionNode _instance = null;
        private static object _instanceObject = new object();

        #endregion

        #region Instance Method

        /// <summary>
        /// Gets an single static instance of information class.
        /// </summary>
        public static ExecuteActionNode Instance
        {
            get
            {
                lock (_instanceObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ExecuteActionNode();
                    }

                    return _instance;
                }
            }
        }

        #endregion

        #region Execution Methods

        /// <summary>
        /// Performs node runtime actions.
        /// </summary>
        /// <param name="container">The outgoing process container from caller node.</param>
        /// <param name="helper">The active <see cref="Development.SDK.Module.Controller.Helper.ScriptHelper"/> script helper controller.</param>
        /// <returns>Outgoing <c>Development.SDK.Module.Controller.Container.ProcessContainer</c> of the node.</returns>
        public Development.SDK.Module.Controller.Container.ProcessContainer Execute(Development.SDK.Module.Controller.Container.ProcessContainer container, Development.SDK.Module.Controller.Helper.ScriptHelper helper)
        {
            return container;
        }

        #endregion
    }
}
