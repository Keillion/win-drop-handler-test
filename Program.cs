using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using SharpShell.SharpDropHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_drop_handler_test
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.ClassOfExtension, ".txt")]//.kei-drop-test
    class KeillionWinDropHandlerTest : SharpDropHandler
    {
        protected override void DragEnter(DragEventArgs dragEventArgs)
        {
            dragEventArgs.Effect = DragDropEffects.Link;
        }

        protected override void Drop(DragEventArgs dragEventArgs)
        {
            MessageBox.Show("SelectedItemPath: " + SelectedItemPath + ", DragItem: " + DragItems.FirstOrDefault());
        }
    }

    [ComVisible(true)]
    [COMServerAssociation(AssociationType.ClassOfExtension, ".txt")]
    class KeillionWinContextMeauTest : SharpContextMenu
    {
        protected override bool CanShowMenu()
        {
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            var menu = new ContextMenuStrip();

            var item = new ToolStripMenuItem { Text = "just test" };

            menu.Items.Add(item);

            return menu;
        }
    }
}
