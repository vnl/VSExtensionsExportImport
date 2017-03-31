using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel.Design;

namespace VSExtensionsExportImport
{
    internal sealed class VSExtensionsExpImpCmd
    {
        public const int CommandId = 0x0100;

        public static readonly Guid CommandSet = new Guid("316ab650-ebaf-45f8-81eb-71f75d36dd2d");

        private readonly Package package;

        private VSExtensionsExpImpCmd(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }

        public static VSExtensionsExpImpCmd Instance
        {
            get;
            private set;
        }

        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        public static void Initialize(Package package)
        {
            Instance = new VSExtensionsExpImpCmd(package);
        }

        private void MenuItemCallback(object sender, EventArgs e)
        {
        }
    }
}
